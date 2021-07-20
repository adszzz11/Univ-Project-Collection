import 'package:flutter/material.dart';
import 'package:flutter_new/Screens/auth/auth_find.dart';
import 'package:flutter_new/constraints.dart';

import '../../server.dart';

class AuthLogin extends StatefulWidget {
  const AuthLogin({Key key}) : super(key: key);

  @override
  _AuthLoginState createState() => _AuthLoginState();
}

class _AuthLoginState extends State<AuthLogin> {
  GlobalKey<FormState> _formKey = GlobalKey<FormState>();
  TextEditingController _idController =
      TextEditingController(text: "test@naver.com");
  TextEditingController _pwController =
      TextEditingController(text: "asdf123123");

  @override
  Widget build(BuildContext context) {
    return Scaffold(
      body: Form(
        key: _formKey,
        child: Padding(
          padding: const EdgeInsets.symmetric(horizontal: 16),
          child: Column(children: [
            // OnePass Logo 부분
            Padding(
              padding: EdgeInsets.symmetric(vertical: 120),
              child: Column(
                children: [
                  SizedBox(
                    height: 120,
                    child: Image.asset(
                      'assets/images/onepasslogo.png',
                      color: textPrimaryColor,
                    ),
                  ),
                  Text(
                    'One Pass',
                    style: TextStyle(
                        fontSize: 28,
                        color: textPrimaryColor,
                        fontWeight: FontWeight.bold),
                  )
                ],
              ),
            ),
            //Login Card
            Card(
              shape: RoundedRectangleBorder(
                  borderRadius: BorderRadius.circular(32)),
              //카드 색
              // color: ColorRev.white,
              elevation: 7,
              child: Padding(
                padding: const EdgeInsets.all(16.0),
                child: Column(
                  crossAxisAlignment: CrossAxisAlignment.end,
                  children: <Widget>[
                    buildTextFormField(context, _idController,
                        Icon(Icons.account_circle), 'ID'),
                    buildTextFormField(
                        context, _pwController, Icon(Icons.vpn_key), 'PW'),
                    SizedBox(
                      height: 16.0,
                    ),
                    Container(
                      width: MediaQuery.of(context).size.width,
                      child: buildTextButton(context, Text('Sign in'), () {
                        if (_formKey.currentState.validate())
                          server.getReq('authenticate',
                              username: _idController.text,
                              password: _pwController.text);
                      }),
                    ),
                    Container(
                      width: MediaQuery.of(context).size.width * 0.4,
                      child: buildPrimaryTextOnlyButton(
                          context, Text('Forget ID or Password?'), () {
                        /*findId로 가기*/
                        Navigator.push(
                            context,
                            MaterialPageRoute(
                                builder: (context) => AuthFind()));
                      }),
                    ),
                    // Container(
                    //   child: ReUsable.buildTextButton2("Sign In", () {
                    //     if (_formKey.currentState.validate()) {
                    //       print(_idController.text);
                    //       print(_pwController.text);
                    //       server.doPost(context, 'authenticate',
                    //           username: _idController.text,
                    //           password: _pwController.text);
                    //     }
                    //     // _authProvider.goToMain();
                    //   }),
                    //   width: MediaQuery.of(context).size.width,
                    // ),
                    // Container(
                    //     child: ReUsable.buildTextButton4("Forget Id or Password?",
                    //             () {
                    //           _authProvider.updateStatePage('AuthFind');
                    //         }),
                    //     alignment: Align1ment.centerRight),
                  ],
                ),
              ),
            ),
            Container(
              child: buildSecondaryTextOnlyButton(
                  context, Text('Create yout New Account'), () {}),
            ),
          ]),
        ),
      ),
    );
  }
}
