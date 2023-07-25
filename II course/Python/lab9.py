from math import pi
from math import sqrt as sq
from math import *
from openpyxl import load_workbook

print(pi**2)
print(sq(4))
print(sin(3.14))
wb = load_workbook("Excel.xlsx")
sheet = wb['List1']
print(sheet['A1'].value)
sheet['A1'] = "Hello!"
print(sheet['A1'].value)
for i in range(1, 10):
    sheet['C'+str(i)] = i
sheet['C10'] = sum(range(1, 10))
wb.close()