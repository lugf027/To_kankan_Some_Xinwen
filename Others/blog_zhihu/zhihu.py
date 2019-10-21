# -*- coding: utf-8 -*-
# @Time    : 2019/10/18 22:28
# @Author  : Lugf027
# @FileName: zhihu.py
# @Software: PyCharm
# @Github  ：https://github.com/lugf027
import mysql.connector
from selenium import webdriver
import requests
import re
import datetime
import time

time_now = ''
last_results = ''

def get_zhihu_hots():
    url = "https://www.zhihu.com/billboard"
    headers = {"User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) "
                             "AppleWebKit/537.36 (KHTML, like Gecko) Chrome/77.0.3865.120 Safari/537.36",
               "Cookie": '_zap=cd271ee5-93f2-4ff8-88a6-eb3831786792; _xsrf=fJfjdzSakcdlmQ53QHzHAPTKBFonwzvE; '
                         'd_c0="ACDtVb58MRCPToU692do2STPMsu7na-Mvp8=|1570978942"; tst=h; tshl=; '
                         'tgw_l7_route=f2979fdd289e2265b2f12e4f4a478330; '
                         'Hm_lvt_98beee57fd2ef70ccdd5ca52b9740c49=1571204745,1571205252,1571403562,1571408726; '
                         'capsion_ticket="2|1:0|10:1571408977|14:capsion_ticket|44:YjE3OThjZDhmMzExNDcxYThiZDA5YmU1Y'
                         'TkyOGI4YWU=|60e76d774c0640a2397607aaa10ce51a735f8fe42504a837481de8784a9ab02f"; '
                         'Hm_lpvt_98beee57fd2ef70ccdd5ca52b9740c49=1571409097',
               }

    res = requests.get(url, headers=headers)
    res.encoding = 'utf-8'  # 知乎编码方式
    page_con = res.text  # 网页源代码
    reg_hots = re.compile(
        r'>([0-9]+)<\/div>.*?HotList-itemTitle">(.*?)<\/div><div class="HotList-itemMetrics">([0-9]+)')
    hots = reg_hots.findall(page_con)

    if len(hots) <= 0:    # Cookies失效，重定向到登陆界面，找不到热点部分源码
        driver = webdriver.Chrome()
        driver.get(url)  # 模拟浏览器打开
        page_con = driver.page_source  # 网页源代码
        reg_hots = re.compile(
            r'>([0-9]+)<\/div>.*?HotList-itemTitle">(.*?)<\/div><div class="HotList-itemMetrics">([0-9]+)')
        hots = reg_hots.findall(page_con)

    result = []
    for hot in hots:
        result.append(list(hot))  # 元组转列表

    global time_now
    time_now = datetime.datetime.now().strftime("%Y-%m-%d %H:%M:%S")
    print(time_now)
    return result

def begin():
    global time_now
    global last_results
    while True:
        try:
            hot_points = get_zhihu_hots()
            mydb = mysql.connector.connect(
                host="xx",
                user="xx",
                passwd="xx",
                database="xx"
            )
            mycursor = mydb.cursor()
            for hot_point in hot_points:
                num_chan = 51 - int(hot_point[0])
                for last_result in last_results:
                    if hot_point[1] == last_result[1]:
                        num_chan = int(last_result[0])-int(hot_point[0])
                        break

                sql = "INSERT INTO `zhihu1` (NO, TITLE, VALUE, TIME, NUM_CHANGE) VALUES (%s, %s, %s, %s, %s)"
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

# CREATE TABLE IF NOT EXISTS `zhihu1`(
#    `ID` INT(10) UNSIGNED AUTO_INCREMENT,
#    `NO` INT(2) NOT NULL,
#    `TITLE` VARCHAR(50) NOT NULL,
#    `VALUE` INT(5) NOT NULL,
#    `TIME` TIMESTAMP,
#    `COLOR` INT(2) DEFAULT 0 NOT NULL,
#    `NUM_CHANGE` INT(2) DEFAULT 0 NOT NULL,
#    PRIMARY KEY ( `ID` )
# )ENGINE=INNODB DEFAULT CHARSET=utf8;

