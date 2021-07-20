import 'package:jwt_decode/jwt_decode.dart';

class Secret {
  static String _REV_AUTH = "http://34.64.73.179:8760/";
  static String _TY_IP = "http://111.171.6.164:8760/";
  static String _HACKERS = "http://192.168.0.201:8760/";

  static String get path => _REV_AUTH;
  static var jwt;
  static String _token = "";

  static String get token => _token;

  static void setToken(String token) {
    _token = token;
    jwt = Jwt.parseJwt(_token);
    print(jwt);
    print(_token);
  }

  static get getExp =>
      DateTime.fromMillisecondsSinceEpoch(0).add(Duration(seconds: jwt["exp"]));

  static get getSub => jwt['sub'];

  static get getIat =>
      DateTime.fromMillisecondsSinceEpoch(0).add(Duration(seconds: jwt["iat"]));

  static bool get getExpired => Jwt.isExpired(_token);
}