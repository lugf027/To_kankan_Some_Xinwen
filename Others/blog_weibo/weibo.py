# -*- coding: utf-8 -*-
# @Time    : 2019/10/18 20:27
# @Author  : Lugf027
# @FileName: weibo.py
# @Software: PyCharm
# @Github  ：https://github.com/lugf027

from selenium import webdriver  # 从selenium导入webdriver
import requests
import re
import datetime
import mysql.connector
import time
url = "https://s.weibo.com/top/summary"  # 热搜地址
time_now = ''
last_results = []


# 获得51条热搜
def get_hot_points():
    page_con = ""
    try:
        headers = {"User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) "
                                 "AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.120 Safari/537.36",
                   "Cookie": 'SINAGLOBAL=9781581434694.7.1571374609015; '
                             'SCF=ApH2JU9bF_oR74CMtVL2FtGaPZO4gWznUUNZp_OT_OSsO4rTRZpEB1VlLx8qoA1tAGD57NmambXyJWgWze2a'
                             'JvI.; '
                             'SUHB=0ebdtAOvxOVwTM; un=18571466231; '
                             'SUBP=0033WrSXqPxfM72wWs9jqgMF55529P9D9WFsjLZvBxp39G3VFQe6e.c75JpVF02RSKMpShqceoep; '
                             'SUB=_2AkMq9SBLdcPxrARQnvwXzmnibIhH-jyZIEm9An7uJhMyAxgv7nwkqSVutBF-XMet0MocsyDn7Q_BM0_LGQ'
                             'jRVUjI; _'
                             's_tentry=www.baidu.com; UOR=www.cankaoxiaoxi.com,widget.weibo.com,www.baidu.com; '
                             'Apache=6564786228939.318.1571592160663; '
                             'ULV=1571592160677:4:4:1:6564786228939.318.1571592160663:1571406188829; '
                             'WBStorage=384d9091c43a87a5|undefined',
                   }

        res = requests.get(url, headers=headers)  # 尝试直接打开
        res.encoding = 'utf-8'  # 微博编码方式
        page_con = res.text  # 网页源代码

    except Exception as ex:
        print(ex)  # 大概率No host specified.
        driver = webdriver.Chrome()
        driver.get(url)  # 模拟浏览器打开
        page_con = driver.page_source  # 网页源代码
        driver.close()

    finally:
        # 50个排序热搜
        reg_hots = re.compile(
            r'<td class="td-01 ranktop">([0-9]+)<\/td>\s*.*\s+<.*?>(.*?)<\/a>\s*<span>([0-9]+)<\/span>')
        hots = reg_hots.findall(page_con)
        result = []
        for hot in hots:
            result.append(list(hot))  # 元组转列表

        # 1个置顶热搜，序号及搜索度设为0
        reg_top = re.compile(
            r'<td class="td-01"><i class="icon-top"><\/i><\/td>\s*.*\s+ <.*?>(.*?)<\/a>')
        top = reg_top.findall(page_con)
        top = ["0", top[0], "0"]
        result.append(top)
        global time_now
        time_now = datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")
        return result

def begin():
    global time_now
    global last_results
    while True:
        try:
            hot_points = get_hot_points()
            mydb = mysql.connector.connect(
                host="xx",
                user="xx",
                passwd="xx",
                database="xx"
            )
            mycursor = mydb.cursor()
            for hot_point in hot_points:
                num_chan = 51-int(hot_point[0])
                for last_result in last_results:
                    if last_result[1] == hot_point[1]:
                        num_chan = int(last_result[0]) - int(hot_point[0])
                        break
                sql = "INSERT INTO `weibo1` (NO, TITLE, VALUE, TIME, NUM_CHANGE) VALUES (%s, %s, %s, %s, %s)"
                val = (hot_point[0], hot_point[1], hot_point[2], time_now, num_chan)
                mycursor.execute(sql, val)
                mydb.commit()  # 数据表内容有更新，必须使用到该语句
            print(hot_points)
            time.sleep(120)
        except Exception as ex:
            print('-'*30)
            print(ex)
            print('-' * 30)
        finally:
            print(time_now)
            last_results = hot_points

begin()


# CREATE TABLE IF NOT EXISTS `weibo1`(
#    `ID` INT(10) UNSIGNED AUTO_INCREMENT,
#    `NO` INT(2) NOT NULL,
#    `TITLE` VARCHAR(30) NOT NULL,
#    `VALUE` INT(5) NOT NULL,
#    `TIME` TIMESTAMP,
#    `COLOR` INT(2) DEFAULT 0 NOT NULL,
#    `NUM_CHANGE` INT(2) DEFAULT 0 NOT NULL,
#    PRIMARY KEY ( `ID` )
# )ENGINE=INNODB DEFAULT CHARSET=utf8;

# weibo_name = ""  # 用户账号
# weibo_pwd = ""  # 用户密码
# # 可以登录，但没必要
# def login_weibo():
#     driver = webdriver.Chrome()  # Optional argument, if not specified will search path.
#     driver.get('https://weibo.com/')  # 获取微博页面
#     driver.implicitly_wait(5)
#
#     login_name = driver.find_element_by_css_selector("#loginname")  # 用户名输入框
#     login_pwd = driver.find_element_by_css_selector("#pl_login_form > div > div:nth-child(3) > "
#                                                      "div.info_list.password > div > input")  # 密码输入框
#     login_pwd.send_keys(weibo_pwd)
#     login_name.send_keys(weibo_name)
#
#     login_btn = driver.find_element_by_css_selector("#pl_login_form > div > div:nth-child(3) > "
#                                                      "div.info_list.login_btn > a")
#     login_btn.click()  # 点击登录
