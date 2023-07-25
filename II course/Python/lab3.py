import copy

#1
list1 = list("asfa")
print(list1)
list2 = [1, 4, "fasf", 5.6]
print(list2)

#2
list1 = list("asfa")
print(list1)
list2 = copy.copy(list1)
print(list2)
list3 = copy.deepcopy(list2)
print(list3)

#3
list1 = [5,2,7,5,1,8]
list2 = list("asfa") + list1
print(list2)

#4
list1 = [4, 5, 2, 1, 5, 2, 7, 5, 1, 8]
print(list1[0])
#list1[1] = [1, 2, 3]
del list1[2]
print(max(list1))

#5
list1 = None
list2 = [1,2,3,4,5,6,7,8,9,10]
list1 = list2[5:]
print(list1)

#6
list1 = [-5, 1, 5, -2, 8, 12, -42, -11, 0, 10, 1, 3, -3]
list2 = []

i = 0
while i < len(list1):
    if list1[i] > -1:
        list2.append(1)
    else:
        list2.append(list1[i])
    i = i + 1

print(list2)

#7
s = 'Hello'
s = list(s)

i = 0
while i < len(s):
    s[i] = s[i] * 3
    i = i + 1

print(s)

#8
l = [1, 9]
l1 = []

for i in range(*l, 2):
    l1.append(i + 1)

print(l1)

#9
list_ = []
n1 = int(input("Enter first value of sequence: "))
n2 = int(input("Enter second value of sequence: "))

for i in range(n1, n2):
    list_.append(i)

print(list_)