import copy

#1
tuple1 = tuple()
tuple2 = ()
tuple3 = (2, "214")

#2
tuple1 = (2, "214")
tuple2 = tuple1
tuple1 = (2, "214", 5)
print(tuple1)
print(tuple2)

#3
uple1 = (2, "214")
tuple2 = (5, 7) + tuple1
print(tuple2)

#4
tuple1 = (2, 5, 123, 12, 98, 53, 47, 82, 13)
print(tuple1[0])
#tuple1[0] = [1, 2, 3] помилка, кортеж неможливо змінити
print(max(tuple1))

#5
tuple1 = (2, 5, 123, 12, 98, 53, 47, 82, 13)
tuple2 = tuple1[5:]
print(tuple2)

#6
tuple1 = ((2, 6), (5, 1), (3,))
list_ = list(tuple1)
list_.sort()
tuple1 = tuple(list_)
print(tuple1)

#7
t1, t2, t3 = True, False, False
if True in (t1, t2, t3):
    print("YES")
else:
    print("NO")

#8
points = [1, 6, 2, -2, 7]
product = 1
for i in points:
    if len(points) < 0:
        break
    product *= i
else:
    print(f'Product: {product}')

#9
t1 = (['a', 'b'], 'hello')
t2 = ('a', 'b', 'hello')
t1_copy = copy.deepcopy(t1)
t2_copy = t2
print(t1_copy)
print(t2_copy)

#10
tuple_ = tuple(x for x in range(1, 11))
print(tuple_)

#11
tuple_ = tuple(x+x for x in 'spam')
print(tuple_)

#12
tuple_ = tuple(item for index, item in enumerate('spam') if index % 2 == 0)
print(tuple_)

#13
tuple_ = tuple((x, x*x) for x in range(1, 11))
print(tuple_)

#14
PI = 3.14159
list_ = [print(round(PI, x)) for x in range(1, 6)]

#15
list1 = [[1, 2, 3], [4, 7, 8], [5, 4, 3]]
list2 = [list1[i] for i in [0, 2] for j in range(3) if list1[i][j] == 4]
print(list2)

#16
n1 = int(input("Enter the first number: "))
n2 = int(input("Enter the second number: "))
list_ = [x for x in range(n1, n2)]
print(list_)

#17
list1 = [[1, 2, 3], [4, 5, 6], [7, 8, 9]]
list2 = [list1[i][j] for i in [0, 2] for j in range(3) if i % 2 != 0 or j % 2 != 0]
print(list2)

#18
list1 = [-1, 3, -5, 6, 7, 6, -7, 8]
list2 = [x for x in list1 if x > -1]
print(list2)