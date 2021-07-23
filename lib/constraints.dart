import 'package:flutter/material.dart';

const primaryColor = Color.fromRGBO(37, 188, 109, 1.0); //darkgreen
const secondaryColor = Color.fromRGBO(102, 239, 156, 1.0);
const textPrimaryColor = Colors.white;
const textSecondaryColor =
    Color.fromRGBO(100, 100, 100, 1.0); //Color.fromRGBO(200, 200, 200, 1.0);
const errorColor = Colors.red;

buildTextFormField(context, controller, icon, labelText,{keyboardType,inputFormatters, obscureText=false}) {
  return TextFormField(
    controller: controller,
    inputFormatters: inputFormatters,
    obscureText: obscureText,
    decoration: InputDecoration(
        icon: icon,
        labelText: labelText,
        errorStyle: TextStyle(color: Theme.of(context).errorColor)),
    keyboardType: keyboardType,
    validator: (text) {
      if (text == null || text.isEmpty) return 'Please input correctly';
      return null;
    },
  );
}

buildTextButton(context, text, onPressed) {
  return TextButton(
    child: text,
    onPressed: onPressed,
    style: TextButton.styleFrom(primary: textPrimaryColor,backgroundColor: primaryColor),
  );
}
buildPrimaryTextOnlyButton(context, text, onPressed) {
  return TextButton(
    child: text,
    onPressed: onPressed,
    style: TextButton.styleFrom(primary: textSecondaryColor,backgroundColor: Colors.transparent),
  );
}
buildSecondaryTextOnlyButton(context, text, onPressed) {
  return TextButton(
    child: text,
    onPressed: onPressed,
    style: TextButton.styleFrom(primary: textPrimaryColor,backgroundColor: Colors.transparent),
  );
}
buildSelectTextButton(context, text, onPressed) {
  return TextButton(
    child: text,
    onPressed: onPressed,
    style: TextButton.styleFrom(primary: textPrimaryColor,backgroundColor: Colors.transparent),
  );
}