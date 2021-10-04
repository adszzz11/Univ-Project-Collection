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
        Ask.askComment.addAll(newEntries);
        currentPage++;
        isPerformingRequest = false;
      });
    }
  }

  /// from - inclusive, to - exclusive
  Future<dynamic> req() async {
    return Future.delayed(Duration(seconds: 2), () {
      // return server.getReq('getaskComment[provider.askNum',page: currentPage);
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
        return Padding(
          padding: const EdgeInsets.symmetric(horizontal: 16, vertical: 4),
          child: Column(
            crossAxisAlignment: CrossAxisAlignment.start,
            children: [
              Row(
                mainAxisAlignment: MainAxisAlignment.spaceAround,
                children: [
                  Column(
                    children: [
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceAround,
                        children: [
                          SizedBox(
                            width: 200,
                            child: Text(
                              Ask.askComment[provider.askNum][index]['title'].toString(),
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
                            '${Ask.askComment[provider.askNum][index]['hits'].toString()} hits',
                            style: TextStyle(
                                fontSize: 10, fontWeight: FontWeight.bold),
                          ),
                        ],
                      ),
                      Row(
                        mainAxisAlignment: MainAxisAlignment.spaceAround,
                        children: [
                          Text(
                            Ask.askComment[provider.askNum][index]['postDate'].toString(),
                            style: TextStyle(fontSize: 10),
                          ),
                          SizedBox(
                            width: 55,
                          ),
                          Text(
                            Ask.askComment[provider.askNum][index]['nickname'],
                            style: TextStyle(fontSize: 10),
                          ),
                        ],
                      ),
                    ],
                  ),
                  buildPrimaryTextOnlyButton(context, Icon(Icons.arrow_forward_ios),
                          () {
                        provider.updatePage(index);
                        // server.getReq('getBoardDetail',
                        //     boardNum: index, isPined: false, context: context);
                        // Future.delayed(Duration(seconds: 1),() {
                        //   return Navigator.push(context,MaterialPageRoute(builder: (context)=>AskDetail()));
                        // });
                      }),
                ],
              ),
              Divider(
                height: 8,
                thickness: 1,
                color: Colors.grey,
              ),
            ],
          ),
        );
      },
    );
  }
  @override
  Widget build(BuildContext context) {
    return Consumer<AskProvider>(
      builder: (context, provider, child) {
        return Scaffold(
          resizeToAvoidBottomInset: false,
          backgroundColor: primaryColor,
          body: Padding(
            padding: const EdgeInsets.symmetric(horizontal: 16),
            child: Column(
              mainAxisAlignment: MainAxisAlignment.end,
              crossAxisAlignment: CrossAxisAlignment.start,
              children: [
                Row(
                  mainAxisAlignment: MainAxisAlignment.spaceBetween,
                  children: [
                    Container(
                      width: MediaQuery.of(context).size.width * 0.7,
                      child: Text(
                        Ask.askComment[provider.askNum][provider.askNum]['nickname'].toString(),
                        overflow: TextOverflow.ellipsis,
                        maxLines: 3,
                        style: TextStyle(
                            fontSize: 20,
                            color: Colors.white,
                            fontWeight: FontWeight.bold),
                      ),
                    ),
                    Text(
                        Ask.askComment[provider.askNum][provider.askNum]['poasDate'].toString(),
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
                      Ask.askComment[provider.askNum][provider.askNum]['comment'].toString(),
                      style: TextStyle(
                          fontSize: 12,
                          color: Colors.white,
                          fontWeight: FontWeight.bold),
                    ),
                    // Text(
                    //   Ask.askComment[provider.askNum[provider.askNum]['hits'].toString(),
                    //   style: TextStyle(
                    //       fontSize: 12,
                    //       color: Colors.white,
                    //       fontWeight: FontWeight.bold),
                    // ),
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
                        Padding(
                          padding: const EdgeInsets.all(16.0),
                          child: Text(
                            Ask.askComment[provider.askNum][provider.askNum]['content'].toString(),
                          ),
                        ),
                      ],
                    ),
                  ),
                ),
                Container(
                  width: MediaQuery.of(context).size.width,
                  height: MediaQuery.of(context).size.height * 0.48,
                  child: Card(
                    shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(32),),
                    // elevation: 7,
                    shadowColor: Colors.transparent,

                    color: Colors.transparent,
                    child: Column(
                      children: [
                        Container(
                          alignment: Alignment.centerLeft,
                          padding: EdgeInsets.symmetric(horizontal: 36, vertical: 0),
                          child: Text(
                            '댓  글',
                            style: TextStyle(
                                fontSize: 24,
                                color: Colors.white,
                                fontWeight: FontWeight.bold),
                          ),
                        ),
                        Container(
                          height: MediaQuery.of(context).size.height * 0.79,
                          padding: EdgeInsets.symmetric(vertical: 10),
                          child: ListView.builder(
                            controller: _scrollController,
                            itemCount: Ask.askComment[provider.askNum].length + 1,
                            itemBuilder: (context, index) {
                              int itemCount = Ask.askComment[provider.askNum].length;
                              if (index == Ask.askComment[provider.askNum].length)
                                return _buildProgressIndicator();
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
                            // server.getReq('getAskDetail',
                            //     askNum: provider.askNum - 1,
                            //     context: context);

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
                            // server.getReq('getAskDetail',
                            //     askNum: provider.askNum + 1,
                            //     context: context);
                            Future.delayed(Duration(seconds: 1), () {
                              return provider.nextPage();
                            });
                          }
                        },
                      ),
                    ],
                  ),
                )
              ],
            ),
          ),
        );
      },
    );
  }
}
