def check_id():
    a = 2
    b = 2
    print(f'id(a)={id(a)} id(b)={id(b)}')
    if a is b:
        print(id(a))
    else:
        print("They are not equal")

def account():
    name = input("Please, enter your name: ")
    age = input("Also, enter your age: ")
    residence = input("And, where are you living: ")

    print(f'This is {name}\nHe/She is {age}\nHe/She live in {residence}')

def exersise_for_user():
    #4 * 100 - 54
    correct_answer = 346
    user_answer = input("Do you want to solve an exercise? (y/n)\n")
    if user_answer != "y":
        print("Goodbye!")
        return
    print("Look and solve the example and write the correct answer: ")
    user_answer = input("4 * 100 - 54 = ")

    print(f'Correct answer - {correct_answer}, your answer - {user_answer}.')
    if correct_answer == user_answer:
        print("Well done, you solved the exercise correctly.")
    else:   
        print("Unfortunately your answer is incorrect.")
    print("Thank you for trying to solve our exercise :)")

def numbers():
    print("Enter 4 numbers: ")
    var_a = int(input())
    var_b = int(input())
    var_c = int(input())
    var_d = int(input())
    
    first_sum = var_a + var_b
    second_sum = var_c + var_d
    division = first_sum / second_sum
    print(f'Division = {division:2.f}')


check_id()
print("===================")
account()
print("===================")
exersise_for_user()
print("===================")
numbers()