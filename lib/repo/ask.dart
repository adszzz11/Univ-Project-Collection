import 'package:flutter/material.dart';

class Ask {
  static dynamic _askList=[];
  static get askList => _askList;
  static void initAskList(var value) {
    _askList=value;
    print('AskList init complete!');
    print('AskList length ${_askList.length}');
  }
  static bool isAskListEmpty() {
    return _askList.isEmpty;
  }
  static dynamic _askComment=[];
  static get askComment=>_askComment;
  static void initAskComment(var value) {
    _askComment=value;
    print('AskComment init complete!');
  }
  static bool isAskCommentEmpty() {
    return _askComment.isEmpty;
  }
}

class AskProvider extends ChangeNotifier {

  int _askNum=0;
  int _maxPage=0;

  get askNum => _askNum;
  get maxPage => _maxPage;

  void updatePage(int askNum) {
    _askNum=askNum;
    _maxPage = Ask.askList.length;
    notifyListeners();
  }

  void previousPage() {
    _askNum--;
    notifyListeners();
  }

  void nextPage() {
    _askNum++;
    notifyListeners();
  }

}