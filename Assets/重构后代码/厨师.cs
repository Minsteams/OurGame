using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 厨师 : NPC
{
	public static int counter = 1;
    public GameObject chess;

    private void Start()
    {
        currentState = new StandState();
    }

    class StandState : NPCState
    {
        public override void Enter(NPC npc)
		{
            npc.animator.SetBool("isTalk", false);
        }

        public override void Execute(NPC npc)
        {
			if (npc.IfInteracted ()) {
                //print ("act");
                string item = ItemSystem.GetCurrentItem();
                if ( item == "棋盘")
                {
                    ItemSystem.DeleteItem("棋盘");
                    npc.ChangeState(new TalkState30());
                    counter = 3;
                }
                else if (厨师.counter>=3&&item == "金币")
                {
                    ItemSystem.DeleteItem("金币");
                    ++厨师.counter;
                }
                else switch (厨师.counter)
                    {
                        case 1: npc.ChangeState(new TalkState11()); break;
                        case 2: npc.ChangeState(new TalkState21()); break;
                        case 3: npc.ChangeState(new TalkState31()); break;
                        case 4: npc.ChangeState(new TalkState41()); break;
                        case 5: npc.ChangeState(new TalkState51()); break;
                        case 6: npc.ChangeState(new TalkState61()); break;

                    }
			}
        }

        public override void Exit(NPC npc)
        {

        }
    }
	class TalkState11 :NPCState
	{
		public override void Enter(NPC npc)
		{
			LogSystem.Speak ("你好呀！",Player.current);
            ++厨师.counter;
        }
		public override void Execute (NPC npc)
		{
			if (LogSystem.IfSpeakEnded ()) {
				npc.ChangeState (new TalkState12());
			}
		}
	}

	class TalkState12 :NPCState
	{
		public override void Enter(NPC npc)
		{
			LogSystem.Speak ("你好，小姑娘。有什么事吗。",npc);
		}
		public override void Execute (NPC npc)
		{
			if (LogSystem.IfSpeakEnded ()) {
				npc.ChangeState (new TalkState13());
			}
		}
	}

	class TalkState13 :NPCState
	{
		public override void Enter(NPC npc)
		{
			LogSystem.Speak ("厨师先生，能帮我把前面那扇门打开吗？", Player.current);
		}
		public override void Execute (NPC npc)
		{
			if (LogSystem.IfSpeakEnded ()) {
				npc.ChangeState (new TalkState14());
			}
		}
	}
	class TalkState14 :NPCState
	{
		public override void Enter(NPC npc)
		{
			LogSystem.Speak ("哦~是想让我帮你开门啊。", npc);
			
		}
		public override void Execute (NPC npc)
		{
			if (LogSystem.IfSpeakEnded ()) {
				npc.ChangeState (new TalkState15());
			}
		}
	}
    class TalkState15 : NPCState
    {
        public override void Enter(NPC npc)
        {
            LogSystem.Speak("这样吧，你陪我下几盘井字棋，你赢了我就给你开门。", npc);

        }
        public override void Execute(NPC npc)
        {
            if (LogSystem.IfSpeakEnded())
            {
                npc.ChangeState(new TalkState16());
            }
        }
    }
    class TalkState16 : NPCState
    {
        public override void Enter(NPC npc)
        {
            LogSystem.Speak("不过我只有棋子，没有棋盘，你帮我想办法找一张棋盘来吧。", npc);

        }
        public override void Execute(NPC npc)
        {
            if (LogSystem.IfSpeakEnded())
            {
                npc.ChangeState(new TalkState17());
            }
        }
    }
    class TalkState17 : NPCState
    {
        public override void Enter(NPC npc)
        {
            LogSystem.Speak("好吧。。",Player.current);

        }
        public override void Execute(NPC npc)
        {
            if (LogSystem.IfSpeakEnded())
            {
                npc.ChangeState(new TalkState18());
            }
        }
    }
    class TalkState18 : NPCState
    {
        public override void Enter(NPC npc)
        {
            LogSystem.Speak("看到有用的道具，用鼠标右键点击就能捡起来哦。右下角就是道具栏按钮了。", npc);

        }
        public override void Execute(NPC npc)
        {
            if (LogSystem.IfSpeakEnded())
            {
                npc.ChangeState(new TalkState19());
            }
        }
    }
    class TalkState19 : NPCState
    {
        public override void Enter(NPC npc)
        {
            LogSystem.Speak("在道具栏中按右键可以使用道具，分别按左键和右键可以组合两个道具。好好使用这个功能吧。", npc);

        }
        public override void Execute(NPC npc)
        {
            if (LogSystem.IfSpeakEnded())
            {
                npc.ChangeState(new StandState());
            }
        }
    }
    class TalkState21 : NPCState
	{
		public override void Enter(NPC npc)
		{
			LogSystem.Speak ("找到棋盘了吗？找到了就给我吧。", npc);

		}

		public override void Execute(NPC npc)
		{
			if (LogSystem.IfSpeakEnded ()) {
				npc.ChangeState (new TalkState18 ());
			}
		}
	}
    class TalkState30 : NPCState
    {
        public override void Enter(NPC npc)
        {
            LogSystem.Speak("自己画的棋盘啊。也凑合吧。不过。。", npc);

        }

        public override void Execute(NPC npc)
        {
            if (LogSystem.IfSpeakEnded())
            {
                npc.ChangeState(new TalkState31());
            }
        }
    }
    class TalkState31 : NPCState
	{
		public override void Enter(NPC npc)
		{
			LogSystem.Speak ("年轻人啊，下棋没有金币怎么行呢？", npc);

		}

		public override void Execute(NPC npc)
		{
			if (LogSystem.IfSpeakEnded ()) {
				npc.ChangeState (new TalkState32());
			}
		}
	}
    class TalkState32 : NPCState
    {
        public override void Enter(NPC npc)
        {
            LogSystem.Speak("怎么不行。。。T T", Player.current);

        }

        public override void Execute(NPC npc)
        {
            if (LogSystem.IfSpeakEnded())
            {
                npc.ChangeState(new TalkState33());
            }
        }
    }
    class TalkState33 : NPCState
    {
        public override void Enter(NPC npc)
        {
            LogSystem.Speak("当然不行。", npc);

        }

        public override void Execute(NPC npc)
        {
            if (LogSystem.IfSpeakEnded())
            {
                npc.ChangeState(new StandState());
            }
        }
    }
    class TalkState41 : NPCState
	{
		public override void Enter(NPC npc)
		{
			LogSystem.Speak ("给你金币，现在可以开始下了吧~", Player.current);
        }

		public override void Execute(NPC npc)
		{
			if (LogSystem.IfSpeakEnded ()) {
				npc.ChangeState (new TalkState42());
			}
		}
	}
    class TalkState42 : NPCState
    {
        public override void Enter(NPC npc)
        {
            LogSystem.Speak("好，我们来下棋吧~", npc);
        }

        public override void Execute(NPC npc)
        {
            if (LogSystem.IfSpeakEnded())
            {
                npc.ChangeState(new PlayState());
            }
        }
    }
    class PlayState : NPCState
    {
        public override void Enter(NPC npc)
        {
            GameObject.Instantiate(npc.GetComponent<厨师>().chess);
            npc.ChangeState(new beforeTalkState51());
        }
    }
    class beforeTalkState51 : NPCState
    {
        public override void Execute(NPC npc)
        {
            if (GameSystem.IfWin())
            {
                ++厨师.counter;
                npc.ChangeState(new TalkState51());
            }
            else if (GameSystem.IfClose())
            {
                npc.ChangeState(new StandState());
            }
        }
    }
    class TalkState51 : NPCState//胜利
	{
		public override void Enter(NPC npc)
		{
          
			LogSystem.Speak ("算了算了，反正你也赢不了我，钥匙给你，你自己过去吧。", npc);
            ++厨师.counter;
        }

		public override void Execute(NPC npc)
		{
			if (LogSystem.IfSpeakEnded ()) {
				npc.ChangeState (new TalkState52());
            }
		}
	}
    class TalkState52 : NPCState
    {
        public override void Enter(NPC npc)
        {

            LogSystem.Speak("哇~，谢谢厨师先生~",Player.current);
        }

        public override void Execute(NPC npc)
        {
            if (LogSystem.IfSpeakEnded())
            {
                npc.ChangeState(new StandState());
                ItemSystem.AddItem("小钥匙");
            }
        }
    }
    class TalkState61 : NPCState
	{
		public override void Enter(NPC npc)
		{
            LogSystem.Speak("你好呀~厨师先生~", Player.current);
        }

		public override void Execute(NPC npc)
		{
			if (LogSystem.IfSpeakEnded ()) {
				npc.ChangeState (new TalkState62 ());
			}
		}

		public override void Exit(NPC npc)
		{

		}
	}
	class TalkState62 : NPCState
	{
		public override void Enter(NPC npc)
		{
			LogSystem.Speak ("你好啊。", npc);
		}

		public override void Execute(NPC npc)
		{
			if (LogSystem.IfSpeakEnded ()) {
				npc.ChangeState (new StandState ());
			}
		}

	}
}
