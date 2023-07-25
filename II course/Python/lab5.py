#1
set1 = {"safas", "agwasd"}
set2 = set([2, 6, "fsdf"])
print(set1)
print(set2)

#2
set1 = {"safas", "agwasd"}
set2 = set([2, 6, "fsdf"])
set1.update(set2)
print(set1)

#3
set1 = {"safas", "agwasd"}
set2 = set([2, 6, "fsdf"])
set3 = {*set1, *set2}
print(set3)

#4
set_ = {"skafsf", "sfaf", 23, 9, "sfa"}
print(set_)
value = input()
print("Yes" if value in set_ else print("No"))

#5
set1 = {"janfjsa", "askf", 214, 64, "sflaf", 156}
set2 = {"janfjsa", "code", 64, 156}
set3 = {*(set1-set2)}
print(set3)

#6
set1 = {"janfjsa", "askf", 214, 64, "sflaf", 156}
set2 = {"janfjsa", "code", 64, 156}
set3 = {*(set1 & set2)}
print(set3)

#7
set_ = set((x, x**3) for x in range(10))
print(sorted(set_))

#8
set_ = {"a"}
set_.add(2)
set_.add((1, 5))
print(set_)

#9
set_ = {"a"}
set_.add(2)
set_.add((1, 5))
#set_.remove(4)
set_.discard(4)
set_.discard(2)
print(set_)

#10
set_ = {"a"}
set_.add(2)
set_.add((1, 5))
set_.clear()
print(set_)

#11
set_ = {"a"}
set_.add(2)
set_.add((1, 5))
del set_
#print(set_)

#12
string = "sajfnasf"
fset = frozenset(string)
print(fset)

#13
l = [x for x in range(6)]+[x for x in range(3, 12)]
set_ = set(l)
print(f'{l=}')
print(f'{set_=}')

#14
dict1 = {}
dict2 = {}
dict3 = dict(*dict1, *dict2)

#15
dict1 = {1: "saf", 2: "dasfaf"}
dict2 = {3: "safasf"}
dict3 = dict(f=dict1.get(1), s=dict2.get(3))

#16
dict1 = {1: "saf", 2: "dasfaf", 3: "safasf"}
print(dict1)

#17
for i in range(1, 4):
    print(f'{i}: ', dict1.get(i))

#18
word = int(input())
print("Yes" if word in dict1 else "No")

#19
dict_ = dict.fromkeys(("one", "two", "three"), 33)
print(dict_)

#20
dict_ = dict.fromkeys(("one", "two", "three"), (33, 44))
print(dict_)

#21
dict_ = {x: x*2 for x in range(5)}
print(dict_)

#22
d = dict(a="hello", b=2, c=3, d="hello")
list_ = [key for key in d if d[key] == "hello"]
print(list_)

#23
dict_ = {}
dict_[0] = "af"
dict_["a"] = "sfa"
dict_[(1, 1)] = "sagaw"
print(dict_)

#24
dict_ = dict(((1, 'one'), (2, 'two')))
print(dict_)

#25
dict_ = dict([(1,'one'),(2,'two')])
print(dict_)

#26
d = {'1': 'one', '2': 'two'}
d_ = {int(key): value for key, value in d.items()}
print(d_)

#27
d = {'1': 'one', '2': 'two'}
d.pop("1")
print(d)

#28
d = {'1': 'one', '2': 'two'}
d.clear()