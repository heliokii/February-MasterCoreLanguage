#include <iostream>
using namespace std;

int search(int arr[], int size, int key){
    for (int ctr = 0; ctr < size; ctr++){
        if (arr[ctr] == key){
            return ctr;
        }
    }
    return -1;
}

int main(void) {
    int size = 10
    int arr[] = {5, 12, 79, 2, 16, 37, 18, 97, 55, 11};
    int key = 55;
    
    int position = search(arr, size, key);
    if (position == -1){
        cout << "Element not found!" << endl;
    } else {
        cout << "Element Found at Position" << position + 1 << endl;
    }
    return 0;
}