# -*- coding: utf-8 -*-
# @Time    : 2019/10/18 15:47
# @Author  : Lugf027
# @FileName: kaiyuanzhongguo.py
# @Software: PyCharm
# @Github  ：https://github.com/lugf027
import string

from selenium import webdriver
import re

url = "https://www.oschina.net/news"
type_dic = {
    "zhzx": "20",  # 综合资讯
    "hyzx": "60",  # 行业资讯
    "bcyyzx": "80",  # 编程语言资讯
}


# 考虑到行业资讯并没有那么多，20条就涉及数月，没必要设置翻页了
def get_news(type):
    driver = webdriver.Chrome()
    driver.get(url)
    page_con = driver.page_source  # 网页源代码

    reg_con = re.compile(
        r'<h3 class="header"><a href="(.*?)" target="_blank" title="(.*?)">(.*?)<\/a><\/h3>(\s.*){5,11}'
        r'\s+<div class="item">(.*?)<\/div>')  # sm写网页的，弄这么复杂，👴👴匹配了好久

    news_ = reg_con.findall(page_con)
    result = []
    for num in range(int(type_dic[type]), int(type_dic[type]) + 20):
        result.append(list(news_[num]))  # 元组转列表，方便设置新闻条目完整url
    print(len(result))
    return result


print(get_news("bcyyzx"))
