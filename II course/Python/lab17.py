from tkinter import *


def click_button():
    global year_of_birth
    year_of_birth -= 2
    btnText.set("Bezoshchuk {}".format(year_of_birth))


root = Tk()
root.title("207 Group")
root.geometry("800x600")

year_of_birth = 2003
btnText = StringVar()
btnText.set("Bezoshchuk {}".format(year_of_birth))
btn = Button(textvariable=btnText, text=f"Bezoshchuk, {year_of_birth}",background="Blue", foreground="Yellow",
             padx="30", pady="10", font="30", command=click_button)
btn.pack()
root.mainloop()