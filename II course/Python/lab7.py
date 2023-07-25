def comparison(a, b):
    return a if a > b else b

def sum_(a=1, b=1, c=1, d=1):
    return a + b + c + d

def multiplication(a, b, c, d=1):
    return a * b * c * d

def multiplication(*params):
    product = 1
    for value in params:
        product *= value
    return product

def swap(a, b):
    return b, a

def foo(list_):
    temp_list = []
    for item in list_:
        temp_list.append(item*2)
    return temp_list

def foo_str(string):
    temp_string = string.split(' ')
    string = [i[0] for i in temp_string]
    return string

def sum_num(num):
    return 0 if num == 0 else num % 10 + sum_num(num // 10)

def count_min_value(*params):
    return params.count(min(*params))

def fibonacci(n):
    f1 = f2 = 1

    print(f1, f2, end=' ')
    for i in range(2, n):
        (f1, f2) = (f2, f1 + f2)
        print(f2, end=' ')

def circle_area(radius):
    print(PI)
    return PI * radius * radius

def foo1():
    var = 1
    print(f"Var in Foo1: {var}")

    def foo2():
        var = 2

        def foo3():
            nonlocal var
            var = 3

        foo3()
        print(f"Var after Foo3 {var}")

    foo2()
    print(f"Var after Foo2 {var}")

#1
print(comparison(1, 3))
#2
print(comparison(5.1, 3.9))
#3
print(comparison(2.7, 2))
#4
print(f"""First option: {sum_()};\nSecond option: {sum_(2)};\nThird option: {sum_(2, 6)};
Fourth option: {sum_(2, 6, 1)};\nFifth option: {sum_(2, 6, 1, 9)}""")
#5
print(multiplication(a=2, b=5, c=8))
#6
print(multiplication(1, 2, 3, 4, 5, 6, 7))
#7
print(swap(6, 7))
#8
print(foo([2, 5, 1, 8]))
#9
print(foo_str("Hello world"))
#10
print(sum_num(123))
#11
list_ = [int(i) for i in input("Enter numbers: ").split()]
print(count_min_value(*list_))
#12
n = int(input("Enter number: "))
fibonacci(n)
#13
global PI
PI = 3.14159265
radius = int(input("Enter radius of the circle: "))
print(f'Area of the circle: {circle_area(radius)}')
#14
foo1()