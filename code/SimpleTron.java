import java.util.Scanner;

public class SimpleTron {
    public static void main(String[] args) {
        Scanner input = new Scanner(System.in);
        System.out.println("*** Welcome to Simpletron! ***\n" +
                "*** Please enter your program one istruction ***\n" +
                "*** (or data word) at a time. I will type the ***\n" +
                "*** location number and a question mark (?) ***\n" +
                "*** You then type the word for that location. ***\n" +
                "*** Type the sectinel -99999 to stop entering ***\n" +
                "*** your program ***");
        //감시 제어 반복을 사용하여 양의 수 입력 및 합계 출력
        //  A   int[] arrA = {1009, 2009, 4107, 4207, 3010, 2110, 4000, 1110, 4300, 0, 0};
        //카운터 제어 반복을 사용하여 7개의 음수 및 양수 입력 및 평균 출력
        //  B   int[] arrB = {1020, 2020, 2121, 3220, 2122, 1023, 2023, 3025, 2125, 2021, 3122, 2121, 4214, 4005, 2025, 3220, 2124, 1124, 4300, 0, 0, 0, 0, 0};
        //일련의 수를 입력하여 가장 큰 수 결정 후 출력
        //  C   int[] arrC = {1017, 2017, 3217, 2118, 1019, 2020, 3119, 4109, 4011, 2019, 2120, 2017, 3118, 2117, 4216, 4004, 1120, 4300, 0, 0, 0, 0};
        int[] arr = new int[100];
        int temp, index = 0;
        System.out.println("Please enter instructions.");
        while (index < 100) {
            System.out.print("Code "+index+" : ");
            try {
                temp = input.nextInt();
                if (isOverflow(temp))
                    if (temp == -99999)
                        break;
                    else
                        System.out.println("*** Please enter instruction to right format. ***");
                else
                    arr[index++] = temp;
            } catch (Exception e) {
                System.out.println("*** Please enter instruction to right format. ***");
            }
        }
        SimpleTron s = new SimpleTron(arr);
        System.out.println("*** Program loading completed. ***");
        System.out.println("*** Program execution begins. ***");
        s.compile();
        s.printRegisters();
        s.printMemory();
        System.out.println("*** Program execution terminated. ***");
    }

    int[] memory = new int[100];
    int accumulator; //누산기 레지스터 표현
    int instructionCounter; //수행중인 메모리의 위치 탐지
    int operationCode; // 수행중인 SML 중 왼쪽 두 개 숫자 -> 명령 부분
    int operand; // 수행중인 SML 중 오른쪽 두 개 숫자 -> 저장소 부분
    int instructionRegister;
    boolean isExcute = true;
    Scanner sc = new Scanner(System.in);

    public SimpleTron(int[] arr) {
        accumulator = 0;
        instructionCounter = 0;
        instructionRegister = 0;
        operationCode = 0;
        operand = 0;
        for (int i = 0; i < arr.length; i++) {
            if (isOverflow(arr[i]))  //허용범위를 넘었을 때
                break;
            memory[i] = arr[i];
        }
    }

    static boolean isOverflow(int index) {
        if(Math.abs(index)>9999) return true;
        return false;
    }

    void compile() {
        while (isExcute) {
            if (instructionCounter == 99) //다 검사했을 때
                isExcute = false;
            else {
                instructionRegister = memory[instructionCounter];
                operand = instructionRegister % 100;
                operationCode = instructionRegister / 100;
                ++instructionCounter;
            }
            switch (operationCode / 10) {
                case 1:
                    ioAccess();
                    break;
                case 2:
                    lsAccess();
                    break;
                case 3:
                    calcAccess();
                    break;
                case 4:
                    controlAccess();
                    break;
            }
        }
    }

    void ioAccess() {//read, write
        switch (operationCode) {
            case 10:
                System.out.print("(?) : ");
                memory[operand] = sc.nextInt();
                break;
            case 11:
                System.out.println(memory[operand]);
                break;
        }
    }

    void lsAccess() {//load, store
        switch (operationCode) {
            case 20:
                accumulator = memory[operand];
                break;
            case 21:
                memory[operand] = accumulator;
                break;
        }
    }

    void calcAccess() {//add, substract, divide, multiply
        int temp=accumulator;
        switch (operationCode) {
            case 30:
                accumulator += memory[operand];
                break;
            case 31:
                accumulator -= memory[operand];
                break;
            case 32:
                if (memory[operand] == 0) {
                    System.out.println("*** Attempt to divide by zero. ***");
                    System.out.println("*** Simpletron execution abnomally terminated. ***");
                    isExcute = false;
                }
                accumulator /= memory[operand];
                break;
            case 33:
                accumulator *= memory[operand];
                break;
        }
        if(isOverflow(accumulator)) {
            System.out.println("*** Simpletron execution abnomally terminated. ***");
            accumulator=temp;
            isExcute=false;
        }

    }

    void controlAccess() {
        switch (operationCode) {
            case 40:
                instructionCounter = operand;
                break;
            case 41:
                if (accumulator < 0)
                    instructionCounter = operand;
                break;
            case 42:
                if (accumulator == 0)
                    instructionCounter = operand;
                break;
            case 43:
                isExcute = false;
                System.out.println("*** Simpletron execution terminated. ***");
                break;
        }
    }

    void printRegisters() {
        System.out.println("REGISTERS :");
        System.out.printf("%-25s%+05d\n", "accumulator", accumulator);
        System.out.printf("%-28s%02d\n", "instructionCounter", instructionCounter);
        System.out.printf("%-25s%+05d\n", "instructionRegister", instructionRegister);
        System.out.printf("%-28s%02d\n", "operationCode", operationCode);
        System.out.printf("%-28s%02d\n", "operand", operand);
    }

    void printMemory() {
        System.out.println("MEMORY :");
        System.out.printf("%5s\t", "");
        for (int i = 0; i < 10; i++)
            System.out.printf("%5d\t", i);
        for (int i = 0; i < 10; i++) {
            System.out.printf("\n%5d\t", i * 10);
            for (int j = 0; j < 10; j++)
                System.out.printf("%+05d\t", memory[i * 10 + j]);
        }
        System.out.println();
    }
}