import math

def power(x, n):
	result = 1
	for i in range(n):
		result *= x
	return result

def printStars(n):
	s = ""
	for i in range(n) :
		s += "*"
	print(s)
