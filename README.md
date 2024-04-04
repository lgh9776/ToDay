## 하루하루 캐릭터와 대화로 알아보는 나의 성격유형! - ToDay
Unity Version : 2020.3.22f1

Build Settings : Android

해상도 : 1920x1080 Portrait

<240321 업데이트 노트>
- 해상도 조절 (모바일 크기에서 pc로 변경되어 있었음) > 완료

  //포트폴리오 해상도 화면 수정본으로 업데이트

- 홈, 맵 데이터 연동 (맵 이동 시 데이터 초기화 됨)
- 자동 세이브 기능 or 세이브 버튼 추가 (-> 나가기 했을 경우 데이터 저장x)
- **Json으로 세이브할 캐릭터 데이터 클래스로 뽑기** //데이터 저장 및 관리 용이 + 클래스 형태로 안뽑으면 Json으로 저장 불가 27
> 배운점 : 저장이 필요한 데이터들은 클래스로 뽑아두기 (objData 등 괜히 따로 뽑아두는게 아니었다!)
>
> 개발자 협업 시 초기 스타일 맞춤 뿐만 아니라 회의에 코드 리뷰 등을 왜 하는지 알겠다. 수정하려고 다른 파트 보니까 이해 안됨 + 스타일을 맞추지 않아서 수정에 어려움 27

- 맵에서도 캐릭터의 수치를 볼 수 있도록
- 맵에서 메뉴바 추가
- 상단에 상호작용 횟수 표시 (1/3)
- 상호작용 3회 시 집에 가야한다는 멘트 수정

- 같은 장소에서 같은 대화를 하지 않도록 > ObjectData

- 집 이동 시 대화를 읽을 시간 추가

- 안드로이드 빌드
- 모바일 방향키 삽입
- 플레이스토어에 출시해보기

- 인트로에 새로하기, 계속하기 추가

배운 점, 느낀 점
협업 시 간략한 코드 설명 (변수 이름을 쉽게 알아볼 수 있도록 설정해야겠다)

<240330>
- 홈 씬 새로 제작
- 기획서 노션 정리 (Branch 정리 포함)

<240331>
- 캐릭터 배치, 상호작용 설정
- 대화 하드코딩 -> 대사 스크립트 따로 제작 후 삽입

<240401>
- new/map > 캐릭터 테스트 배치 //새로운 브랜치 만들어서 캐릭터 이벤트 작업
