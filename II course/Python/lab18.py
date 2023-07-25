from tkinter import *


def click_button():
    entry2.insert(0, entry1.get())


root = Tk()
root.title("207 Group")
root.geometry("800x600")
label1 = Label(text="Your surname:")
button1 = Button(text="Press, after entering the last name.", width=200, command=click_button)
entry1 = Entry(width=80)
entry2 = Entry(width=80)

label1.pack()
entry1.pack()
button1.pack()
entry2.pack()
root.mainloop()