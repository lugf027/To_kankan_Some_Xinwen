# -*- coding: utf-8 -*-
# @Time    : 2019/10/18 20:27
# @Author  : Lugf027
# @FileName: weibo.py
# @Software: PyCharm
# @Github  ：https://github.com/lugf027

from selenium import webdriver  # 从selenium导入webdriver
import requests
import re

weibo_name = ""  # 用户账号
weibo_pwd = ""  # 用户密码
url = "https://s.weibo.com/top/summary"  # 热搜地址


# 可以登录，但没必要
def login_weibo():
    driver = webdriver.Chrome()  # Optional argument, if not specified will search path.
    driver.get('https://weibo.com/')  # 获取微博页面
    driver.implicitly_wait(5)

    login_name = driver.find_element_by_css_selector("#loginname")  # 用户名输入框
    login_pwd = driver.find_element_by_css_selector("#pl_login_form > div > div:nth-child(3) > "
                                                     "div.info_list.password > div > input")  # 密码输入框
    login_pwd.send_keys(weibo_pwd)
    login_name.send_keys(weibo_name)

    login_btn = driver.find_element_by_css_selector("#pl_login_form > div > div:nth-child(3) > "
                                                     "div.info_list.login_btn > a")
    login_btn.click()  # 点击登录


# 获得51条热搜
def get_hot_points():
    page_con = ""
    try:
        res = requests.get(url)  # 尝试直接打开
        res.encoding = 'utf-8'  # 微博编码方式
        page_con = res.text  # 网页源代码

    except Exception as ex:
        print(ex)  # 大概率No host specified.
        driver = webdriver.Chrome()
        driver.get(url)  # 模拟浏览器打开
        page_con = driver.page_source  # 网页源代码

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

        return result

print(get_hot_points())
