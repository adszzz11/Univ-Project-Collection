# Flutter Renew
졸업으로 인한 프로젝트 중단<br/>
Flutter mobile Renew 프로젝트. 일시적으로 사용하며, 리팩토링 완료 시 레포지토리 삭제 예정<br/>

Flutter 공부용 레포지토리와 구현체로 나누어 활용 예정.<br />
해당 레포지토리는 구현체로 사용

<hr>

프로젝트 전체 구조 : <https://github.com/Team-Rev/MSA-SERVER>


## Flutter Mobile
시스템을 모바일로 이용할 수 있게끔 구현한 어플리케이션이다.<br/>
요청이 만들어지면 MSA 서버에 요청을 하고, 응답을 받아 사용자에게 전시한다.

### 사용된 라이브러리
* Provider : 전역 데이터 관리를 위한 라이브러리. 주로 객체 간 정보 통신에 사용.
* DIO : RESTful한 데이터 통신을 위한 라이브러리. MSA 서버로 데이터 요청 / 응답 데이터 처리 에 사용
* JWT : Access Token과 Refresh Token을 발급하여 사용자 인증에 사용.
