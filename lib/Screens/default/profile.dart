import 'package:flutter/material.dart';
import 'package:flutter_new/constraints.dart';

import '../../secret.dart';

class DefaultProfile extends StatelessWidget {
  TextEditingController temp;
  @override
  Widget build(BuildContext context) {
    temp=TextEditingController(text: Secret.token);
    return Center(
      child: Container(
        height: 300,
        child: Card(
          shape:
          RoundedRectangleBorder(borderRadius: BorderRadius.circular(32)),
          child: Padding(
            padding: const EdgeInsets.all(16.0),
            child: Column(
              mainAxisAlignment: MainAxisAlignment.center,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Text('토큰 \n ${Secret.token}'),
                buildTextFormField(context, temp, null, null),
                Text(
                    '\n해석하면 \n\nUserId : ${Secret.getSub}\nIAT : ${Secret.getIat}\nEXP : ${Secret.getExp}'),
              ],
            ),
          ),
        ),
      ),
    );
  }
}
