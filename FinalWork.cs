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