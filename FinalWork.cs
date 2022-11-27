// 1. Создание массива с входными данными(строковое значение) и максимальной длины элемента в массиве

string[] array = {"22", "3f24", "i4", "f321"," w", "5673g", "4 i", "1", " "};
int maxLengthElementArray = 3;

// 2. Разработка метода, который будет обрабатывать строковый массив и выдает количество элементов в массиве, удовлетворяющие требованиям

int CounterNecessaryElementsArray(string[] array, int maxLengthElement){
    int count = 0;
    for(int i = 0; i < array.Length; i++){
        string testElementArray = array[i];
        if(testElementArray.Length <= maxLengthElement){
            count++;
        }
    }
    return count;
}

// 3. Разработка метода, который будет обрабатывать строковый массив и выдает массив со значениями, длинна которых меньше или ровна 3 символам

string[] GetArrayWithLengthElementsNotGreaterThanOrEqualTo(string[] array, int lengthNewArray, int maxLengthElement){
    string[] newArray = new string[lengthNewArray];
    for(int i = 0, count = 0; (i < array.Length) && (count < lengthNewArray); i++){
        string testElementArray = array[i];
        if(testElementArray.Length <= maxLengthElement){
            newArray[count] = testElementArray;
            count++;
        }
    }
    return newArray;
}

//4. Разработка метода, который будет выводить массив из элементов отвечающих условиям задачи

void PrintArray(string[] array, string[] arrayResult){
    Console.Write($"['{String.Join("', '", array)}'] -> ");
    Console.Write($"['{String.Join("', '", arrayResult)}']");
}