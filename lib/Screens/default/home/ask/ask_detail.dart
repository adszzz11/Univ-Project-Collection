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
                      Ask.askList[provider.askNum]['title'].toString(),
                      style: TextStyle(
                          fontSize: 12,
                          color: Colors.white,
                          fontWeight: FontWeight.bold),
                    ),
                  ],
                ),
                Container(
                  width: MediaQuery.of(context).size.width,
                  height: MediaQuery.of(context).size.height * 0.8,
                  child: Card(
                    shape: RoundedRectangleBorder(
                        borderRadius: BorderRadius.circular(32)),
                    elevation: 7,
                    child: Column(
                      children: [
                        Padding(
                          padding: const EdgeInsets.all(16.0),
                          child: Text(
                            Ask.askList[provider.askNum]['content'].toString(),
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
