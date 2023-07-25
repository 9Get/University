class NotAdultException(Exception):
    pass


try:
    age = int(input())
    if age < 18:
        raise NotAdultException
except NotAdultException:
    print("Not the right age.")
except Exception:
    print("Check your code.")

try:
    file = open('C:\\Users\\9Get\\Desktop\\file.txt', "w")
    string = "Hi there!"
    file.writelines(string)
except Exception:
    print("Check your request!")
else:
    print("All is ok.")
finally:
    file.close()
    print("File closed.")