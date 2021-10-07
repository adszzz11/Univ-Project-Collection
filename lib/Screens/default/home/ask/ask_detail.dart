import 'package:flutter/material.dart';
import 'package:flutter_new/repo/ask.dart';
import 'package:provider/provider.dart';

import '../../../../constraints.dart';
import '../../../../server.dart';

class AskDetail extends StatefulWidget {
  @override
  _AskDetailState createState() => _AskDetailState();
}

class _AskDetailState extends State<AskDetail> {
  ScrollController _scrollController = new ScrollController();
  bool isPerformingRequest = false;
  int currentPage = 1;
  int askId = -1;

  @override
  void dispose() {
    _scrollController.dispose();
    super.dispose();
  }

  @override
  void initState() {
    super.initState();
    _scrollController.addListener(() {
      if (_scrollController.position.pixels ==
          _scrollController.position.maxScrollExtent) {
        _getMoreData();
      }
    });
  }

  _getMoreData() async {
    if (!isPerformingRequest) {
      setState(() => isPerformingRequest = true);
      List<dynamic> newEntries = await req(); //returns empty list
      if (newEntries.isEmpty) {
        double edge = 50.0;
        double offsetFromBottom = _scrollController.position.maxScrollExtent -
            _scrollController.position.pixels;
        if (offsetFromBottom < edge) {
          _scrollController.animateTo(
              _scrollController.offset - (edge - offsetFromBottom),
              duration: new Duration(milliseconds: 500),
              curve: Curves.easeOut);
        }
      }
      setState(() {
        Ask.askComment[askId].addAll(newEntries);
        currentPage++;
        isPerformingRequest = false;
      });
    }
  }

  /// from - inclusive, to - exclusive
  Future<dynamic> req() async {
    return Future.delayed(Duration(seconds: 2), () {
      return server.getReq('getAskComment', askId: askId, page: currentPage);
    });
  }

  Widget _buildProgressIndicator() {
    return new Padding(
      padding: const EdgeInsets.all(8.0),
      child: new Center(
        child: new Opacity(
          opacity: isPerformingRequest ? 1.0 : 0.0,
          child: new CircularProgressIndicator(
            valueColor: AlwaysStoppedAnimation<Color>(primaryColor),
          ),
        ),
      ),
    );
  }

  Widget _buildAskComment(int index) {
    return Consumer<AskProvider>(
      builder: (context, provider, child) {
        return Card(
          elevation: 7,
          shape:
              RoundedRectangleBorder(borderRadius: BorderRadius.circular(32)),
          child: Padding(
            padding: const EdgeInsets.all(16.0),
            child: Column(
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Row(
                  mainAxisAlignment: MainAxisAlignment.spaceAround,
                  children: [
                    SizedBox(
                      width: 200,
                      child: Text(
                        Ask.askComment[Ask.askList[provider.askNum]['askId']]
                                [index]['nickname']
                            .toString(),
                        // maxLines: 1,
                        overflow: TextOverflow.ellipsis,
                        style: TextStyle(
                            fontSize: 12, fontWeight: FontWeight.bold),
                      ),
                    ),
                    SizedBox(
                      width: 28,
                    ),
                    Text(
                      '${Ask.askComment[Ask.askList[provider.askNum]['askId']][index]['postDate'].toString()}',
                      style:
                          TextStyle(fontSize: 10, fontWeight: FontWeight.bold),
                    ),
                  ],
                ),
                Padding(
                  padding: const EdgeInsets.symmetric(vertical: 8),
                  child: Text(
                    Ask.askComment[Ask.askList[provider.askNum]['askId']][index]
                            ['comment']
                        .toString(),
                    style: TextStyle(fontSize: 12),
                  ),
                ),
              ],
            ),
          ),
        );
      },
    );
  }

  @override
  Widget build(BuildContext context) {
    TextEditingController _commentController = TextEditingController();
    GlobalKey<FormState> _formKey = GlobalKey<FormState>();

    return Consumer<AskProvider>(
      builder: (context, provider, child) {
        askId = Ask.askList[provider.askNum]['askId'];
        return Scaffold(
          // resizeToAvoidBottomInset: false,
          backgroundColor: primaryColor,
          body: Padding(
            padding: const EdgeInsets.symmetric(horizontal: 16),
            child: ListView(
              // mainAxisAlignment: MainAxisAlignment.end,
              // crossAxisAlignment: CrossAxisAlignment.start,
              physics: BouncingScrollPhysics(),
              children: [
                Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Container(
                      width: MediaQuery.of(context).size.width * 0.7,
                      child: Text(
                        Ask.askList[provider.askNum]['title'].toString(),
                        overflow: TextOverflow.ellipsis,
                        maxLines: 3,
                        style: TextStyle(
                            fontSize: 20,
                            color: Colors.white,
                            fontWeight: FontWeight.bold),
                      ),
                    ),
                    Text(
                      Ask.askList[provider.askNum]['nickname'].toString(),
                      style: TextStyle(
                          fontSize: 12,
                          color: Colors.white,
                          fontWeight: FontWeight.bold),
                    ),
                  ],
                ),
                Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Text(
                      Ask.askList[provider.askNum]['postDate'].toString(),
                      style: TextStyle(
                          fontSize: 12,
                          color: Colors.white,
                          fontWeight: FontWeight.bold),
                    ),
                    Text(
                      '${Ask.askList[provider.askNum]['hits'].toString()} hits',
                      style: TextStyle(
                          fontSize: 12,
                          color: Colors.white,
                          fontWeight: FontWeight.bold),
                    ),
                  ],
                ),
                Container(
                  width: MediaQuery.of(context).size.width,
                  height: MediaQuery.of(context).size.height * 0.3,
                  child: Card(
                    shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(32)),
                    elevation: 7,
                    child: Column(
                      children: [
                        Container(
                          padding: const EdgeInsets.all(16.0),
                          height: MediaQuery.of(context).size.height * 0.23,
                          child: Text(
                            Ask.askList[provider.askNum]['content'].toString(),
                          ),
                        ),
                        Container(
                          alignment: Alignment.centerRight,
                          padding: EdgeInsets.symmetric(horizontal: 32),
                          child: buildTextButton(
                              context,
                              Text(
                                  '${Ask.askList[provider.askNum]['recommend'].toString()} ❤'),
                              () {
                            setState(() {
                              Ask.askList[provider.askNum]['recommend']++;
                              //recommend 추가하는 로직 구성 요망
                            });
                          }),
                        ),
                      ],
                    ),
                  ),
                ),
                Container(
                  width: MediaQuery.of(context).size.width,
                  child: Column(
                    children: [
                      Container(
                        alignment: Alignment.centerLeft,
                        padding:
                            EdgeInsets.symmetric(horizontal: 36, vertical: 0),
                        child: Text(
                          '댓  글',
                          style: TextStyle(
                              fontSize: 24,
                              color: Colors.white,
                              fontWeight: FontWeight.bold),
                        ),
                      ),
                      Container(
                        height: MediaQuery.of(context).size.height * 0.4,
                        padding: EdgeInsets.symmetric(vertical: 10),
                        child: ListView.builder(
                          controller: _scrollController,
                          itemCount: Ask
                                  .askComment[Ask.askList[provider.askNum]
                                      ['askId']]
                                  .length +
                              1,
                          itemBuilder: (context, index) {
                            int itemCount = Ask
                                .askComment[Ask.askList[provider.askNum]
                                    ['askId']]
                                .length;
                            if (index ==
                                Ask
                                    .askComment[Ask.askList[provider.askNum]
                                        ['askId']]
                                    .length) return _buildProgressIndicator();
                            if (itemCount > 0) return _buildAskComment(index);
                            return Center(
                              child: Text(
                                '댓글이 없습니다.',
                                style: TextStyle(
                                    fontSize: 24,
                                    color: Colors.grey,
                                    fontWeight: FontWeight.bold),
                              ),
                            );
                          },
                        ),
                      ),
                    ],
                  ),
                ),
                Container(
                  child: Row(
                    mainAxisAlignment: MainAxisAlignment.spaceEvenly,
                    children: [
                      buildSecondaryTextOnlyButton(
                        context,
                        Text('이전'),
                        () {
                          if (provider.askNum - 1 >= 0) {
                            server.getReq('getAskComment',
                                askId: Ask.askList[provider.askNum - 1]
                                    ['askId'],
                                page: 0);
                            Future.delayed(Duration(seconds: 1), () {
                              return provider.previousPage();
                            });
                          }
                        },
                      ),
                      buildSecondaryTextOnlyButton(
                        context,
                        Text('목록'),
                        () {
                          Navigator.pop(context);
                        },
                      ),
                      buildSecondaryTextOnlyButton(
                        context,
                        Text('다음'),
                        () {
                          if (provider.askNum + 1 < provider.maxPage) {
                            server.getReq('getAskComment',
                                askId: Ask.askList[provider.askNum + 1]
                                    ['askId'],
                                page: 0);
                            Future.delayed(Duration(seconds: 1), () {
                              return provider.nextPage();
                            });
                          }
                        },
                      ),
                    ],
                  ),
                ),
                Container(
                  color: Colors.white,
                  child: Row(
                    children: [
                      Container(
                        width: MediaQuery.of(context).size.width * 0.75,
                        padding: EdgeInsets.symmetric(horizontal: 8),
                        child: Form(
                          key: _formKey,
                          child: buildTextFormField(
                              context, _commentController, null, '댓글을 입력하세요', validator: primaryValidator),
                        ),
                      ),
                      buildTextButton(context, Text('제출'), () {
                        server.getReq('addAskComment',
                            askComment: _commentController.text,
                            refAsk: Ask.askList[provider.askNum + 1]['askId']);
                      })
                    ],
                  ),
                ),
              ],
            ),
          ),
        );
      },
    );
  }
}
