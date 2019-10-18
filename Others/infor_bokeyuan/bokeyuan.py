# -*- coding: utf-8 -*-
# @Time    : 2019/10/18 19:57
# @Author  : Lugf027
# @FileName: bokeyuan.py
# @Software: PyCharm
# @Github  ：https://github.com/lugf027

import requests
import re

url_dic = {
    "news": "https://news.cnblogs.com?",  # 考虑到页数，在域名后多加'?'
    "recommend": "https://news.cnblogs.com/n/recommend?",
    "week": "https://news.cnblogs.com/n/digg?type=week",
    "today": "https://news.cnblogs.com/n/digg?type=today",
    "yesterday": "https://news.cnblogs.com/n/digg?type=yesterday",
    "month": "https://news.cnblogs.com/n/digg?type=month",
}

def get_news(type, page="1"):
    try:
        if page.isdigit():
            url = url_dic[type] + "&page="+page  # 翻页

            res = requests.get(url)
            res.encoding = 'utf-8'  # 博客园编码方式
            page_con = res.text  # 网页源代码
            reg_con = re.compile(r'\s<a href="(.*?)" target="_blank">'
                                 r'(.*?)<\/a>(\s.*){10}\s+发布于 <span class="gray">(.*?)<\/span>')

            news_ = reg_con.findall(page_con)
            result = []
            for news in news_:
                news = list(news)   # 元组转列表，方便设置新闻条目完整url
                news[0] = "https://news.cnblogs.com" + news[0]
                del news[2]  # 去除新闻标题与发布时间中间无用部分
                result.append(news)
            return result
    except Exception as ex:
        print(ex)
        return None


type = "news"
page = "3"
print(get_news(type, page))
print(get_news("today"))
