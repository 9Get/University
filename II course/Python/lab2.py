def numbers():
    var_a = int(input("Enter 4 numbers:\n"))
    var_b = int(input())
    var_c = int(input())
    var_d = int(input())

    first_sum = var_a + var_b
    second_sum = var_c + var_d

    print(f'First division = {first_sum / second_sum: .2f}')
    print(f'Second division = {first_sum // second_sum: .2f}')
    print(f'Third division = {first_sum % second_sum: .2f}')

def work_with_strings():
    txt = 'Hello, world'
    print(txt[:5])
    new_string = txt[:3]
    print(new_string)
    new_string2 = txt[2:]
    print(new_string2)

    print(txt[::2])
    txt = txt.upper()
    print(txt)

    print(txt.replace("H", "J", 1))
    print("J" + txt[1:])

    # txt = txt + 2  видає помилку, конкатенація відбудеться тільки з рядками, тобто txt = txt + str(2)
    # print(txt)
    txt = txt * 2
    print(txt)

def entering_string():
    string = input("Enter text:\n")

    while True:
        if string == "exit" or string == "Exit":
            return
        print(string)
        string = input()

def check_user_symbol():
    string = "Programming save the world!"
    user_sym = input("Please, enter a symbol:\n")

    if user_sym in string:
        print("Yes")
    else:
        print("No")


numbers()
print("===================")
work_with_strings()
print("===================")
entering_string()
print("===================")
check_user_symbol()
print("===================")