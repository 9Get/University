class Mark:
    def __init__(self, x=0, y=0):
        self.x = x
        self.y = y

    def __call__(self, new_x, new_y):
        self.x = new_x
        self.y = new_y

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
mark1(2, 4)
print(mark1 + mark2)