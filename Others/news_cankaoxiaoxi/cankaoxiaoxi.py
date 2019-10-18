# -*- coding: utf-8 -*-
# @Time    : 2019/10/18 14:59
# @Author  : Lugf027
# @FileName: cankaoxiaoxi.py
# @Software: PyCharm
# @Github  ：https://github.com/lugf027

import requests
import re

url_dic = {
    "shwx": "http://www.cankaoxiaoxi.com/china/shwx/",
    "zgwj": "http://www.cankaoxiaoxi.com/china/zgwj/",
    "szyw": "http://www.cankaoxiaoxi.com/china/szyw/",

    "ytxw": "http://www.cankaoxiaoxi.com/world/ytxw/",
    "omxw": "http://www.cankaoxiaoxi.com/world/omxw/",
    "qtdq": "http://www.cankaoxiaoxi.com/world/qtdq/",
    "hqbl": "http://www.cankaoxiaoxi.com/world/hqbl/",
    "gjgd": "http://www.cankaoxiaoxi.com/world/gjgd/",

    "zgjq": "http://www.cankaoxiaoxi.com/mil/zgjq/",
    "gjjq": "http://www.cankaoxiaoxi.com/mil/gjjq/",
    "wqzb": "http://www.cankaoxiaoxi.com/mil/wqzb/",

    "zgcj": "http://www.cankaoxiaoxi.com/finance/zgcj/",
    "gjcj": "http://www.cankaoxiaoxi.com/finance/gjcj/",
    "sygs": "http://www.cankaoxiaoxi.com/finance/sygs/",
    "jrsc": "http://www.cankaoxiaoxi.com/finance/jrsc/",
    "cjgd": "http://www.cankaoxiaoxi.com/finance/cjgd/",

    "china": "http://column.cankaoxiaoxi.com/g/china/",
    "world": "http://column.cankaoxiaoxi.com/g/world/",
    "cartoon": "http://column.cankaoxiaoxi.com/cartoon/",
}


def get_news(type, page="1"):
    try:
        if page.isdigit():
            url = url_dic[type] + str(page) + ".shtml"

            res = requests.get(url)
            res.encoding = 'utf-8'  # 参考消息网编码方式
            page_con = res.text  # 网页源代码
            reg_con = re.compile(r'<li><span class="f-r arial cor999">(.*?)<\/span><a href="(.*?)" target="_blank" style="color:">(.*?)<\/a><\/li>')

            news_ = reg_con.findall(page_con)
            result=[]
            for news in news_:
                result.append(list(news))  # 元组转列表，方便设置新闻条目完整url
            return result
    except Exception as ex:
        print(ex)
        return None

type = "zgcj"
page = "3"
print(get_news(type))
print(get_news(type, page))
print(get_news(type, 2))