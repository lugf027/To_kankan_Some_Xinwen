# -*- coding: utf-8 -*-
# @Time    : 2019/10/18 22:28
# @Author  : Lugf027
# @FileName: zhihu.py
# @Software: PyCharm
# @Github  ：https://github.com/lugf027

from selenium import webdriver
import requests
import re


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
    print(len(result))
    return result


print(get_zhihu_hots())
