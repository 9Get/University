import json

with open('C:\\Users\\9Get\\Desktop\\Python_file.txt', 'w') as file:
    file.write("A few letters\n")
    file.writelines("A few more letters\n")

    print(f'File name: {file.name}\nFile mode: {file.mode}')

with open('C:\\Users\\9Get\\Desktop\\Python_file.txt', 'r') as file:
    file_text1 = file.read(4)
    file_text2 = file.readline(1)
    file_text3 = file.readlines()
    print(f'\nFirst reading: {file_text1}\nSecond reading: {file_text2}\nThird reading: {file_text3}\nSimple reading: ')
    for line in file:
        print(line, end='')

data = {"r": "Red", "y": "Yellow", "b": "Blue"}
with open('C:\\Users\\9Get\\Desktop\\Python_file_Json.txt', 'w') as file:
    data_json = json.dumps(data)
    file.write(data_json)

with open('C:\\Users\\9Get\\Desktop\\Python_file_Json.txt', 'r') as file:
    print(f"Json data from file: {json.load(file)}")