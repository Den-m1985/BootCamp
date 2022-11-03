
import cv2

#обращаемся к библиотеке cv2 и класификатору используем "подготовленную"
#нейронную сеть "cv2.data.haarcascades + "haarcascade_frontalface_default.xml"
#по сути обращение к уже обученной нейронной сети
face_cascades = cv2.CascadeClassifier(cv2.data.haarcascades + "haarcascade_frontalface_default.xml")


img = cv2.imread('face.jpg')

#конвертируем из цветной в серую картинку что бы сетка работала корректно 
#с серыми цветами нейронные сети работают более уверенно
cap_grey = cv2.cvtColor(img, cv2.COLOR_BGR2GRAY)

#обращаемся к класификатору а затем и методу detectMultiScale
#для поиска координат в которых находится лицо человека
faund_faces = face_cascades.detectMultiScale(cap_grey)

#испотльзует цикл что бы работать с массивом
for (x, y, w, h) in faund_faces:
    #"рисуем" прямоугольник обозначающий лицо. Цифра 2 ширина рамки.
    cv2.rectangle(img, (x, y), (x + w, y + h), (0, 0, 255), 2)

#выводим "отредактированное" изображение
cv2.imshow('Result', img)
cv2.waitKey(0)

