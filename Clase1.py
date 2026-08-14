def sumar(num1,num2):
    total =num1 + num2
    return total

def restar(num1, num2):
    return num1 - num2

def dividir(n,y):
    if (y==0):
        return "No se puede dividir entre 0"
    else:
        return n/y

def multiplicar(n,y):
    multiplicar = n * y
    return multiplicar

def main():
    num1 = 12
    num2 = 45

    print (restar(num1,num2))  
    print (sumar(num1,num2))  
    print (dividir(num1,num2))  
    print (multiplicar(num1,num2))   

if __name__ =="__main__":
    main()
