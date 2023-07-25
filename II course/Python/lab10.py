class Participant_of_competitions:
    citizenship = "Ukrainian"

    def __new__(cls, *args, **kwargs):
        print("__new__ method")
        return super(Participant_of_competitions, cls).__new__(cls)

    def __init__(self, surname=None, sex=None, number_of_medals=None):
        self.surname = surname
        self.sex = sex
        self.number_of_medals = number_of_medals

    @staticmethod
    def get_citizenship():
        return Participant_of_competitions.citizenship

    @classmethod
    def class_method(cls):
        print("class method")

    def display_info(self):
        print(f"Surname: {self.surname}  Sex: {self.sex}  Number of medals: {self.number_of_medals}")


poc1 = Participant_of_competitions("Jo", "Male", 7)
poc2 = Participant_of_competitions("Mark")
poc1.display_info()
poc2.display_info()

poc2.age = 21
print(Participant_of_competitions.citizenship)
Participant_of_competitions.citizenship = "English"
print(Participant_of_competitions.citizenship)
print(Participant_of_competitions.get_citizenship())
Participant_of_competitions.class_method()