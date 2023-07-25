#1
l = [[1, 8], [5, 3], [2, 6]]
l.sort(key=lambda e: e[1])
print(l)
#2
string = "This is a test string from Andrew"
string = sorted(string.split(), key=lambda w: w[0].upper())
print(string)
#3
l = [
    ('john', 'A', 15),
    ('jane', 'B', 12),
    ('dave', 'B', 10),
]
l = sorted(l, key=lambda e: e[0])
print(l)
#4
ids = ['id1', 'id2', 'id30', 'id3', 'id22', 'id100']
ids = sorted(ids, key=lambda e: len(e))
print(ids)
#5
l = ['cat', 'dog', 'cow']
l = list(map(lambda e: e.upper(), l))
print(l)
#6
l = ['cat', 'dog', 'cow']
l = list(filter(lambda e: e.find('o') != -1, l))
print(l)
#7
s = { 'a' : 4 , 'b' : 3 , 'c' : 2 , 'd' : 1 }
s = sorted(s.items(), key=lambda e: e[1])
print(s)
#8
l = [1, 2, 3, 4, "asd", "asffa"]
l = [x * 2 for x in l]
print(l)

l = [1, 2, 3, 4, "asd", "asffa"]
l = list(map((lambda e: e * 2), l))
print(l)
#9
num = 3.14159265
num = str(num)
num = num.replace('.', '')
print(sum(map(int, num)))
#10
t = ((2, 3), (1, 2))
print(sum((x for item in t for x in item)))
#11
num_list = list(map(int, input().split()))
print(num_list)
#12
l1 = [2, 3, 4, 1]
l2 = [0, 3, 2, 1]
new_list = list(map(lambda i, y: i**y, l1, l2))
print(new_list)