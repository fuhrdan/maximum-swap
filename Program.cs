//*****************************************************************************
//** 670. Maximum Swap    leetcode                                           **
//*****************************************************************************


int maximumSwap(int num) {
    char num_list[20];
    sprintf(num_list, "%d", num);  // Convert the number to a string

    int last[10];
    memset(last, -1, sizeof(last));  // Initialize 'last' array to -1

    // Fill the 'last' array with the last occurrence of each digit
    int len = strlen(num_list);
    for (int i = 0; i < len; i++) {
        last[num_list[i] - '0'] = i;
    }

    // Try to find the maximum swap
    for (int i = 0; i < len; i++) {
        for (int d = 9; d > num_list[i] - '0'; d--) {
            if (last[d] > i) {
                // Swap the digits
                char temp = num_list[i];
                num_list[i] = num_list[last[d]];
                num_list[last[d]] = temp;

                // Convert the modified string back to an integer and return
                return atoi(num_list);
            }
        }
    }

    return num;  // No swap needed
}