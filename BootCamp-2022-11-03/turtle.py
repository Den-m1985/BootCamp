'''
Модуль turtleпредставляет собой расширенную повторную 
реализацию одноименного модуля из стандартного 
дистрибутива Python до версии Python 2.5.
'''

from turtle import *
from random import randint
from time import *

finish =200

t1 = Turtle()#создали объект класса черепаха
t1 = shape("turtle")#поменяли форму объекта
t1 = color(randint(0,255),randint(0,255),randint(0,255))#меняем цвет
#t1 = color("red") #меняем цвет
t1.penup()#поднимаем черепашку чтоб не рисовала
t1.goto(-200,20) #cперемещаем черепашку по координатам
t1.pendown()# опускаем черепашку, чтоб рисовала
t1.speed9(3)

t2 = Turtle()#создали объект класса черепаха
t2 = shape("turtle")#поменяли форму объекта
t2 = color("blue")#меняем цвет
t2.penup()#поднимаем черепашку чтоб не рисовала
t2.goto(-200,-20) #cперемещаем черепашку по координатам
t2.pendown()# опускаем черепашку, чтоб рисовала
t2.speed9(3)

def razmetka():  #функция рисует разметку поля.
    t = Turtle()
    t.speed(0)
    for i in range(1,21):
        t.penup()
        t.goto(-200+i*20,50)
        t.pendown()
        t.goto(-200+i*20,-100)
    t.hideturtle()

razmetka()

def catch1(x,y):   # это обработчик события нажатия
    t1.write('Ouch!', font = ('Arial', 14, 'normal'))  # пишем на экране Ауч
    t1.fd(randint(10,15))   # черепашка делает случайный шаг от 10 до 15

t1.onclick(catch1) # здесь я прикрепляю обработчик к событию нажатия на 1 черепашку

def catch2(x,y):   # это обработчик события нажатия
    t1.write('Ouch!', font = ('Arial', 14, 'normal'))  # пишем на экране Ауч
    t1.fd(randint(10,15))   # черепашка делает случайный шаг от 10 до 15

t2.onclick(catch2) # здесь я прикрепляю обработчик к событию нажатия на 2 черепашку

 
while t1.xcor() < finish and t2.xcor() < finish:
    t1.forward(randint(2,7))  #Черепаха движется вперед в диапазоне от 2 до 7
    t2.forward(randint(2,7))  #
    sleep(0.1)

