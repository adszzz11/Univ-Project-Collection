class Ask {
  static dynamic _askList=[];
  static get askList => _askList;
  static void initAskList(var value) {
    _askList=value;
    print('AskList init complete!');
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