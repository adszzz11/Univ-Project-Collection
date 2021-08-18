# SimpleTron

Simpletron Machine Language.
컴퓨터 구조 수업을 듣고 컴퓨터의 원리를 이해하고자 작성한 프로젝트.
명령을 받아 해석하고 저장, 연산하는 과정을 분석하고 Java 언어로 표현.

## 개요

* 범용 레지스터 가산기(Accumulator)
* 모든 정보들은 워드 단위로 처리 - 부호를 가진 4자리 10진수
* 100워드의 메모리
* 프로그램이 실행되기 전 메모리로 로드. 
* 첫 번째 명령어는 00번 주소에 위치.
* 각 명령어의 첫 2자리는 OP코드로, 프로그램이 수행하는 연산을 나타냄.
* 남은 2자리는 Operand로, 연산이 실행되어야 할 워드가 있는 주소를 나타냄.


연산코드(Operation Code)

![image](https://user-images.githubusercontent.com/54319448/129907112-88ea17f8-a8c9-4606-ae98-429791225b91.png)

코드 실행

![image](https://user-images.githubusercontent.com/54319448/129907128-d884e7b6-a5ed-4411-b0d5-b7761e397ea9.png)

레지스터 상태

![image](https://user-images.githubusercontent.com/54319448/129907135-f073012a-5846-4989-b5ba-972a83f3a173.png)
