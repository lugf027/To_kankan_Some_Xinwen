# -*- coding: utf-8 -*-
# @Time    : 2019/10/18 14:18
# @Author  : Lugf027
# @FileName: renminwang.py
# @Software: PyCharm
# @Github  ：https://github.com/lugf027

import requests
import re

url_dic = {"military": "http://military.people.com.cn/GB/172467/index",
           "world": "http://world.people.com.cn/GB/157278/index",
           "opinion": "http://opinion.people.com.cn/GB/223228/index",
           "society": "http://society.people.com.cn/GB/136657/index",
           "legal": "http://legal.people.com.cn/GB/188502/index",
           "finance": "http://finance.people.com.cn/GB/70846/index",
           "money": "http://money.people.com.cn/stock/GB/222942/index",
           "sports": "http://sports.people.com.cn/GB/22176/index",
           "scitech": "http://scitech.people.com.cn/GB/1057/index",
           "it": "http://it.people.com.cn/GB/243510/index",
           "tw": "http://tw.people.com.cn/GB/104510/index",
           "edu": "http://edu.people.com.cn/GB/1053/index", }


def get_news(type, page="1"):
    try:
        if page.isdigit():
            url = url_dic[type] + str(page) + ".html"

            res = requests.get(url)
            res.encoding = 'GB2312'  # 人民网编码方式
            page_con = res.text  # 网页源代码
            reg_con = re.compile(r"<a href='(.*?)' target=_blank>(.*?)<\/a>\s<em>(.*?)<\/em>")

            news_ = reg_con.findall(page_con)
            result = []
            for news in news_:
                news = list(news)   # 元组转列表，方便设置新闻条目完整url
                news[0] = "http://scitech.people.com.cn" + news[0]
                result.append(news)
            return result
    except Exception as ex:
        print(ex)
        return None

# 试试
type = "scitech"
page = "2"
print(get_news(type))
print(get_news(type, page))
print(get_news(type, 2))
