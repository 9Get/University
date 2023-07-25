import numpy

#1
list1 = [1, 2, 3, 4, 5]
array = numpy.array(list1)
print(array)
#2
tuple1 = [1, 2, 3, 4, 5]
array = numpy.array(tuple1)
print(array)
#3
tuple1 = [2, 4, 6, 8]
list1 = [1, 3, 5, 7, 9]
array1 = numpy.array(tuple1)
array2 = numpy.array(list1)
print(array1.sum())
print(array2.sum())
print(array1.prod())
print(array2.prod())
#4
tuple1 = [2, 4, 6, 8]
list1 = [1, 3, 5, 7, 9]
array1 = numpy.array(tuple1)
array2 = numpy.array(list1)
print(array2 * 3)
#5
array = numpy.array(numpy.arange(0, 3000))
print(array)
#6
array = numpy.empty((2, 1))
#7
array = numpy.empty((2, 2))
array[:1] = 1
#8
array = numpy.empty((2, 2))
array[:1] = 1
print(numpy.size(array))
#9
array = numpy.empty((2, 2))
array[:1] = 1
print(numpy.shape(array))
#10
array = numpy.empty((2, 2))
array[:1] = 1
new_array = array.view()
print(new_array)