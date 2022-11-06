
from random import randint
q = 1000000000
x = randint(0,q)
'''
count_perebor = 1
# Метод последовательного перебора.
for i in range(0,101):
    count_perebor +=1
    if i == x:
        print("Число найдено!")
        break

print("Загаданное чило было ",x, "и потребовалось ", count_perebor, "интераций")

count_random = 1
# Метод случайного отгадывания.
y = randint(0,100)
while x!=y:
  y = randint(0,100)
  count_random+=1

print("Загаданное чило было ",x, "и методом угадывания потребовалось ", count_random, "интераций")
'''


count_binar2=1
print('Давай начнем игру - угадай число от 0 до 100')
left = 0
right = q
mid = (right + left) // 2
#y = int(input('Введите число'))
while x!=mid:
    print(mid)
    if x<mid: 
        print("меньше")
        right = mid - 1
    else:
        print("больше")
        left = mid + 1
    mid = (right + left) // 2
    #y = int(input('Введите число '))
    count_binar2+=1

print("Загаданное чило было ",x, "и методом бинарного поиска потребовалось ", count_binar2, "интераций")


