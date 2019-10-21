# -*- coding: utf-8 -*-
# @Time    : 2019/10/21 19:35
# @Author  : Lugf027
# @FileName: deal_weibo_paiming.py
# @Software: PyCharm
# @Github  ：https://github.com/lugf027
import mysql.connector

mydb = mysql.connector.connect(
    host="xx.xx",
    user="xx",
    passwd="xx",
    database="xx"
)
mycursor = mydb.cursor()
sql_all = "select * from weibo"
mycursor.execute(sql_all)
results = mycursor.fetchall()  # fetchall() 获取所有记录

last_res = []

len_results = len(results)

for i in range(0, len_results):
    if i%51 == 0 and i != 0:
        last_res = results[i-51:i]
    if i <= 50:
        sql_set_0 = "UPDATE `weibo` SET num_change = '0' WHERE id ='"+str(i+2)+"';"
        mycursor.execute(sql_set_0)
        mydb.commit()  # 数据表内容有更新，必须使用到该语句
    else:
        for last_re in last_res:
            if results[i][2] == last_re[2]:
                sql_set_change = "UPDATE `weibo` SET num_change = '"+str(int(last_re[1])-int(results[i][1]))+"' WHERE id ='"+str(i+2)+"';"
                mycursor.execute(sql_set_change)
                mydb.commit()  # 数据表内容有更新，必须使用到该语句
    print(i)
