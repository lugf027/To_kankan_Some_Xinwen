# -*- coding: utf-8 -*-
# @Time    : 2019/10/16 23:01
# @Author  : Lugf027
# @FileName: xinwenlianbo.py
# @Software: PyCharm
# @Github  ：https://github.com/lugf027

from selenium import webdriver
import re
import requests

driver = webdriver.Chrome()
driver.get('http://tv.cctv.com/')

driver.find_element_by_css_selector("#mytxtdafdfasdf").send_keys("新闻联播")
btn_search = driver.find_element_by_css_selector("#search > div > div.inputBox > div > span.buttonVal > "
                                                 "input[type=button]:nth-child(1)")
btn_search.click()  # 点击搜索“新闻联播”，在新标签页打开
all_handles = driver.window_handles  # 获取当前所有标签页
driver.close()  # 关闭CCTV首页
driver.switch_to.window(all_handles[1])  # 定位至搜索结果界面

link_xwlb = driver.find_element_by_css_selector("#video_playlist_cont_1 > font")
link_xwlb.click()  # 在新标签页打开新闻联播页面

all_handles = driver.window_handles
driver.close()  # 关闭搜索结果界面
driver.switch_to.window(all_handles[1])  # 定位至新闻联播页面

page = driver.page_source  # 网页源代码

reg_links = re.compile('<li>\s+<a href="(.*?)" target="_blank">')  # 当日新闻联播主要内容各链接
url_lists = reg_links.findall(page)

for url_list in url_lists:
    print(url_list)
    res = requests.get(url_list)
    res.encoding = 'utf-8'
    page_con = res.text  # 网页源代码
    reg_con = re.compile('<p>(.*?)<\/p>')  # 当条新闻内容
    news_contents = reg_con.findall(page_con)
    for news_content in news_contents:
        print(news_content)



