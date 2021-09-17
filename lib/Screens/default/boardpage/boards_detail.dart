import 'package:flutter/material.dart';
import 'package:flutter_new/constraints.dart';
import 'package:flutter_new/repo/boards.dart';

import '../../../server.dart';

class NoticeDetail extends StatefulWidget {
  int boardNum;
  bool isPined;
  int maxPage;

  NoticeDetail(int boardNum, bool isPined) {
    this.boardNum = boardNum;
    this.isPined = isPined;
    print('boardnum $boardNum');
    maxPage = isPined ? Boards.boardPined.length : Boards.boardPage.length;
  }

  @override
  _NoticeDetailState createState() => _NoticeDetailState();
}

class _NoticeDetailState extends State<NoticeDetail> {
  @override
  Widget build(BuildContext context) {
    // TODO: implement build
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
                    widget.isPined
                        ? Boards.boardPined[widget.boardNum]['title'].toString()
                        : Boards.boardPage[widget.boardNum]['title'].toString(),
                    overflow: TextOverflow.ellipsis,
                    maxLines: 3,
                    style: TextStyle(
                        fontSize: 20,
                        color: Colors.white,
                        fontWeight: FontWeight.bold),
                  ),
                ),
                Text(
                  widget.isPined
                      ? Boards.boardPined[widget.boardNum]['nickname']
                          .toString()
                      : Boards.boardPage[widget.boardNum]['nickname']
                          .toString(),
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
                  widget.isPined
                      ? Boards.boardPined[widget.boardNum]['postDate']
                          .toString()
                      : Boards.boardPage[widget.boardNum]['postDate']
                          .toString(),
                  style: TextStyle(
                      fontSize: 12,
                      color: Colors.white,
                      fontWeight: FontWeight.bold),
                ),
                Text(
                  widget.isPined
                      ? Boards.boardPined[widget.boardNum]['hits'].toString()
                      : Boards.boardPage[widget.boardNum]['hits'].toString(),
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
                        widget.isPined
                            ? Boards.boardPined[widget.boardNum]['detail']
                                .toString()
                            : Boards.boardPage[widget.boardNum]['detail']
                                .toString(),
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
                      if (widget.boardNum - 1 >= 0) {
                        server.getReq('getBoardDetail',
                            boardNum: widget.boardNum - 1,
                            isPined: widget.isPined,
                            context: context);
                      }
                    },
                  ),
                  buildSecondaryTextOnlyButton(
                    context,
                    Text('목록'),
                    () {
                      Navigator.pop(context);
                      // Navigator.push(context, MaterialPageRoute(builder: (context) => MainWidget()));
                    },
                  ),
                  buildSecondaryTextOnlyButton(
                    context,
                    Text('다음'),
                    () {
                      if (widget.boardNum + 1 < widget.maxPage) {
                        Future.delayed(Duration(seconds: 1), () {
                          return server.getReq('getBoardDetail',
                              boardNum: widget.boardNum + 1,
                              isPined: widget.isPined,
                              context: context);
                        });
                        //TODO Navigator로 쓸 수 있을까? 확인해보고 없으면 Provider로 전환 요청.
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
  }
}
