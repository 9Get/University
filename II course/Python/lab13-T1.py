class Mark:
    def __init__(self, x=0, y=0):
        self.x = x
        self.y = y

    def __str__(self):
        return f"(X;Y) = {self.x} : {self.y}"

    def __add__(self, other):
        return Mark(self.x + other.x, self.y + other.y)

    def __iadd__(self, other):
        self.x += other.x
        self.y += other.y
        return self


mark1 = Mark(0, 5)
mark2 = Mark(2, 1)
mark3 = Mark(3, 3)
mark4 = mark1 + mark2
mark4 += mark1
print(mark1 + mark2 + mark3 + mark4)