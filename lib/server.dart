import 'package:dio/dio.dart';
import 'package:flutter/material.dart';
import 'package:flutter_new/Screens/auth/auth_changepw.dart';
import 'package:flutter_new/constraints.dart';
import 'package:flutter_new/main.dart';
import 'package:flutter_new/secret.dart';

import 'Screens/default/default_page.dart';

class Server {
  dynamic getReq(String type,
      {username,
      password,
      userId,
      nickname,
      name,
      DOB,
      phone,
      address,
      detailAddress,
      postNumber,
      context,
      start,
      end,
      page,
      answerMainId}) async {
    String addr;
    Map<String, dynamic> data;
    List<Map<String, dynamic>> submitList = [];
    Map<String, dynamic> queryParameters;
    String reqType;
    //선택지 구분
    switch (type) {
      //Auth
      case 'authenticate': //로그인
        reqType = 'post';
        addr = 'authenticate';
        data = {"username": username, "password": password};
        break;

      case 'signup': //회원가입
        reqType = 'post';
        addr = 'auth/signup';
        data = {
          "userId": userId,
          "password": password,
          "nickname": nickname,
          "name": name,
          "DOB": DOB,
          "phone": phone,
          "address": address,
          "detailAddress": detailAddress,
          "postNumber": postNumber
        };
        break;

      case 'findID':
        reqType = 'post';
        addr = 'auth/findId';
        data = {
          'name': name,
          'phone': phone,
        };
        break;

      case 'findPW':
        reqType = 'post';
        addr = 'auth/findPw';
        data = {
          'userId': userId,
          'name': name,
          'phone': phone,
        };
        break;

      case 'changePW':
        reqType = 'patch';
        addr = 'auth/updatePw';
        print(userId);
        data = {"userId": userId, "newPassword": password};
        break;

      case 'getPinedBoard':
        reqType = 'get';
        addr = 'board/notice-pined';
        break;

      // case 'submit':
      //   reqType = 'post';
      //   addr = 'problem/submit';
      //   var options =
      //   BaseOptions(headers: {'Authorization': 'Bearer ${Secret.token}'});
      //   submitList.clear();
      //
      //   for (int i = 0; i < Questions.submitList.length; i++) {
      //     submitList.add({
      //       'questionId': Questions.questionNumList[i],
      //       'multipleChoiceIds': Questions.submitList[i]
      //     });
      //   }
      //   data = {
      //     'userId': Secret.getSub,
      //     'submitList': submitList,
      //   };
      //   break;
      // case 'getQuestionByRange':
      //   reqType = 'get';
      //   addr = 'problem/rangeQuestions';
      //   queryParameters = {
      //     'start': start,
      //     'end': end,
      //   };
      //   break;
      // case 'getResults':
      //   reqType = 'get';
      //   addr = 'problem/answer/summary';
      //   queryParameters = {'id': Secret.getSub, 'page': 0};
      //   break;
      // case 'getResults2':
      //   reqType = 'get';
      //   addr = 'problem/answer/summary';
      //   queryParameters = {'id': Secret.getSub, 'page': page};
      //   break;
      // case 'getResultQuestions':
      //   reqType = 'get';
      //   addr = 'problem/answer/detail';
      //   queryParameters = {'id': answerMainId};
      //   break;
    }

    Response response =
        await _Req(reqType, addr, queryParameters: queryParameters, data: data);
    // print(response.data);
    switch (type) {
      case 'authenticate':
        //TODO Success, Fail 판별해서 팝업 띄우기 추가
        if (response.data == null) {}
        else {
          Secret.setToken(response.data['jwt']);
          Navigator.push(
              context, MaterialPageRoute(builder: (context) => DefaultPage()));
        }
        break;
      case 'findID':
        _buildFailArert(context, returnType: response.data);
        break;

      case 'findPW':
        if(response.data=='OK') { //비밀번호 바꾸기 허용
          Navigator.push(context, MaterialPageRoute(builder: (context) => ChangePassword(userId: userId,)));
        } else { //반대

        }
        break;

      case 'signup':
        // Navigator.push(
        //     context, MaterialPageRoute(builder: (context) => AuthLogin()));
        //TODO Success, Fail 판별해서 팝업 띄우기 추가
        break;

      case 'changePW':
        print('성공');
        //TODO AlertMessage
        break;

      // case 'submit':
      //   Questions.initQuestionResult(response.data);
      //   return _buildAlert(context);
      //   break;
      // case 'getQuestionByRange':
      //   print(response.data.toString());
      //   Questions.init(response.data);
      //   Navigator.push(
      //       context, MaterialPageRoute(builder: (context) => TestQuestion()));
      //   break;
      // case 'getResults':
      //   Results.initResultSummary(response.data);
      //   Navigator.push(
      //       context, MaterialPageRoute(builder: (context) => ShowResult()));
      //   break;
      // case 'getResults2':
      //   return response.data;
      //
      //   break;
      // case 'getResultQuestions':
      //   Results.initResultQuestions(response.data);
      //   Navigator.push(
      //       context, MaterialPageRoute(builder: (context) => ResultDetail()));
      //   break;
    }
  }

  Future<Response> _Req(String type, String addr,
      {queryParameters, data, options}) async {
    Dio dio = Dio(options);
    Response response;
    switch (type) {
      case 'post':
        response = await dio.post('${Secret.path}$addr', data: data);
        break;
      case 'get':
        response = await dio.get('${Secret.path}$addr',
            queryParameters: queryParameters);
        break;
      case 'patch':
        response = await dio.patch('${Secret.path}$addr', data: data);
        break;
    }
    return response;
  }

  dynamic _buildFailArert(context, {returnType}) {
    return showDialog(
        context: context,
        builder: (context) {
          return AlertDialog(
            shape:
                RoundedRectangleBorder(borderRadius: BorderRadius.circular(32)),
            title: Center(
                child: Text(
              '결    과',
              style: TextStyle(
                color: textPrimaryColor,
                fontSize: 24,
                fontWeight: FontWeight.bold,
              ),
            )),
            contentPadding: EdgeInsets.fromLTRB(24, 12, 24, 0),
            content: Container(
              height: 100,
              child: Card(
                shape: RoundedRectangleBorder(
                    borderRadius: BorderRadius.circular(32)),
                elevation: 0,
                child: Column(
                  mainAxisAlignment: MainAxisAlignment.center,
                  crossAxisAlignment: CrossAxisAlignment.center,
                  children: [
                    Text(
                      returnType.toString() == 'USER NOT FOUND'
                          ? '유저를 찾지 못했습니다.'
                          : '요청하신 아이디는 \n$returnType \n입니다.',
                      style:
                          TextStyle(fontSize: 16, fontWeight: FontWeight.bold),
                    ),
                  ],
                ),
              ),
            ),
            elevation: 7,
            backgroundColor: primaryColor,
            // actionsPadding: EdgeInsets.symmetric(horizontal: 64),
            // actionsOverflowButtonSpacing: 100,
            actions: [
              SizedBox(
                  width: 72,
                  child: buildTextButton(context, Text('이전'), () {Navigator.of(context).pop();})),
            ],
          );
        });
  }
// dynamic _buildAlert(context) {
//   return showDialog<void>(
//       context: context,
//       // barrierDismissible: false,
//       builder: (BuildContext context) {
//         return AlertDialog(
//           shape:
//           RoundedRectangleBorder(borderRadius: BorderRadius.circular(32)),
//           title: Center(
//               child: Text(
//                 '시험 결과',
//                 style: TextStyle(
//                   color: textPrimaryColor,
//                   fontSize: 24,
//                   fontWeight: FontWeight.bold,
//                 ),
//               )),
//           contentPadding: EdgeInsets.fromLTRB(24, 12, 24, 0),
//           content: Container(
//             height: 100,
//             child: Card(
//               shape: RoundedRectangleBorder(
//                   borderRadius: BorderRadius.circular(32)),
//               elevation: 0,
//               child: Column(
//                 mainAxisAlignment: MainAxisAlignment.center,
//                 crossAxisAlignment: CrossAxisAlignment.center,
//                 children: [
//                   Text(
//                     '${Questions.questionResult['totalCount']}개의 문제 중',
//                     style:
//                     TextStyle(fontSize: 16, fontWeight: FontWeight.bold),
//                   ),
//                   Text(
//                     '${Questions.questionResult['correctCount']}개를 맞췄습니다 !',
//                     style:
//                     TextStyle(fontSize: 16, fontWeight: FontWeight.bold),
//                   ),
//                 ],
//               ),
//             ),
//           ),
//           elevation: 7,
//           backgroundColor: primaryColor,
//           actionsPadding: EdgeInsets.symmetric(horizontal: 64),
//           actionsOverflowButtonSpacing: 100,
//           actions: [
//             SizedBox(
//               width: 72,
//               child: ReUsable.buildTextButton(
//                 '상세보기',
//                 Colors.transparent,
//                 ColorRev.white,
//                 onPressed: () {},
//               ),
//             ),
//             SizedBox(
//               width: 72,
//               child: ReUsable.buildTextButton(
//                 '목록으로',
//                 Colors.transparent,
//                 ColorRev.white,
//                 onPressed: () {
//                   Navigator.push(context,
//                       MaterialPageRoute(builder: (context) => MainWidget()));
//                 },
//               ),
//             ),
//           ],
//         );
//       });
// }
}

Server server = Server();
