﻿using Library;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Guideviewer
{
	class CheckBoxViewModel
	{
		public ObservableCollection<CheckBoxModel> AllCheckboxes { get; set; }

		List<Tuple<string, string>> checkBoxTupleInfo = new List<Tuple<string, string>>
		{
            //Master Quest Cape
                //Miniquests
			new Tuple<string, string>( "Abyssal_Reach", "The Abyss" ),
			new Tuple<string, string>( "Bar_Crawl", "Barcrawl" ),
			new Tuple<string, string>( "The_Curse_of_Zaros", "The Curse of Zaros" ),
			new Tuple<string, string>( "Desert_Slayer_Dungeon", "Desert Slayer Dungeon" ),
			new Tuple<string, string>( "Banking_History", "Banking History" ),
			new Tuple<string, string>( "Fur_%27n%27_Seek", "Fur 'n' Seek Wishlist"),
            new Tuple<string, string>( "Ali_The_Trader", "Fur 'n' Seek Wishlist" ),
            new Tuple<string, string>( "Ali_The_Trader", "The General's Shadow" ),
            new Tuple<string, string>( "Ali_The_Trader", "Hopespear's Will" ),
            new Tuple<string, string>( "Ali_The_Trader", "Hunt for Surok" ),
            new Tuple<string, string>( "Ali_The_Trader", "In Memory of The Myreque" ),
            new Tuple<string, string>( "Ali_The_Trader", "Knight Waves Training Grounds" ),
            new Tuple<string, string>( "Ali_The_Trader", "Koschei's Troubles" ),
            new Tuple<string, string>( "From_Tiny_Acorns", "From Tiny Acorns" ),
            new Tuple<string, string>( "Lost_Her_Marbles", "Lost Her Marbles" ),
            new Tuple<string, string>( "A_Guild_of_Our_Own", "A Guild of Our Own" ),
            new Tuple<string, string>( "Ali_The_Trader", "The Lair of Tarn Razorlor" ),
            new Tuple<string, string>( "Ali_The_Trader", "The Lost Toys" ),
            new Tuple<string, string>( "Ali_The_Trader", "Mahjarrat Memories" ),
            new Tuple<string, string>( "Ali_The_Trader", "Mogre" ),
            new Tuple<string, string>( "Ali_The_Trader", "Rag and Bone Man Wishlist" ),
            new Tuple<string, string>( "About_%27Kin_Time", "About 'Kin Time" ),
            new Tuple<string, string>( "Ali_The_Trader", "Returning Clarence" ),
            new Tuple<string, string>( "Ali_The_Trader", "Rogue Trader" ),
            new Tuple<string, string>( "Ali_The_Trader", "Scabarites Notes" ),
            new Tuple<string, string>( "Ali_The_Trader", "Tales of Nomad" ),
            new Tuple<string, string>( "Ali_The_Trader", "Tales of the God Wars" ),
            new Tuple<string, string>( "Ali_The_Trader", "Encountering TzHaar-Ga'al-Kot" ),
            new Tuple<string, string>( "Ali_The_Trader", "Doric's first" ),
            new Tuple<string, string>( "Ali_The_Trader", "Doric's second" ),
            new Tuple<string, string>( "Ali_The_Trader", "Doric's third" ),
            new Tuple<string, string>( "Ali_The_Trader", "Doric's fourth" ),
            new Tuple<string, string>( "Ali_The_Trader", "Doric's fifth" ),
            new Tuple<string, string>( "Ali_The_Trader", "Doric's sixth" ),
            new Tuple<string, string>( "Ali_The_Trader", "Doric's seventh" ),
            new Tuple<string, string>( "Ali_The_Trader", "Doric's eighth" ),
            new Tuple<string, string>( "Ali_The_Trader", "Boric's first" ),
            new Tuple<string, string>( "Ali_The_Trader", "Boric's second" ),
            new Tuple<string, string>( "Ali_The_Trader", "Boric's third" ),
            new Tuple<string, string>( "Fred%27s_Shearings", "Sheep Shearer" ),
            new Tuple<string, string>( "Ali_The_Trader", "Witch's Potion" ),
            new Tuple<string, string>( "Ali_The_Trader", "Stronghold of Player Safety" ),
            new Tuple<string, string>( "Ali_The_Trader", "Stronghold of Security" ),
            new Tuple<string, string>( "Ali_The_Trader", "Purple Cat" ),
            new Tuple<string, string>( "Ali_The_Trader", "Benedict's World Tour" ),


                //Post-Quest
            new Tuple<string, string>( "Aereck%27s_Old_Bones", "Aereck's Old Bones" ),
            new Tuple<string, string>( "Any_Odd_Chicken", "Any Odd Chicken" ),
            new Tuple<string, string>( "Ali_The_Trader", "Heart of Stone - Pet" ),
            new Tuple<string, string>( "Ali_The_Trader", "The Tale of the Muspah - Experience" ),
            new Tuple<string, string>( "Ali_The_Trader", "River of Blood - Haemalchemy" ),
            new Tuple<string, string>( "Ali_The_Trader", "Song from the Depths - Experience" ),
            new Tuple<string, string>( "Ali_The_Trader", "A Shadow over Ashdale - Varies" ),
            new Tuple<string, string>( "Azacorax%27s_Rewards", "Azacorax's Rewards" ),
            new Tuple<string, string>( "Ali_The_Trader", "Archmage Sedridors Chest" ),
            new Tuple<string, string>( "Blinded_by_Ramarno%27s_Teaching", "Blinded by Ramarno's Teaching" ),
            new Tuple<string, string>( "Buy_and_Sell_Some_XP", "Buy and Sell Some XP" ),
            new Tuple<string, string>( "Buying_Up_Ancient_Artefacts", "Buying Up Ancient Artefacts" ),
            new Tuple<string, string>( "Claiming_Azzanadra%27s_Heart", "Claiming Azzanadra's Heart" ),
            new Tuple<string, string>( "Claus_Is_Rising", "Claus Is Rising" ),
            new Tuple<string, string>( "Cook%27s_Delights", "Cook's Delights" ),
            new Tuple<string, string>( "Deep_and_Bloody_Experience", "Deep and Bloody Experience" ),
            new Tuple<string, string>( "Complete_Trekky", "Fires Are Mostly Harmless - Gu'Tanoth Cave" ),
            new Tuple<string, string>( "Chippy_Transport", "Chippy Transport" ),
            new Tuple<string, string>( "Advanced_Sweeping", "Advanced Sweeping - The Apprentice" ),
            new Tuple<string, string>( "Advanced_Sweeping", "Advanced Sweeping - Ali the Hag" ),
            new Tuple<string, string>( "Advanced_Sweeping", "Advanced Sweeping - Old Crone" ),
            new Tuple<string, string>( "Advanced_Sweeping", "Advanced Sweeping - Baba Yaga" ),
            new Tuple<string, string>( "Advanced_Sweeping", "Advanced Sweeping - Kardia" ),
            new Tuple<string, string>( "Around_the_World_in_Six_Ways", "Around the World in Six Ways - Crafting Guild" ),
            new Tuple<string, string>( "Around_the_World_in_Six_Ways", "Around the World in Six Ways - Lumber Yard" ),
            new Tuple<string, string>( "Around_the_World_in_Six_Ways", "Around the World in Six Ways - Castle Wars" ),
            new Tuple<string, string>( "Around_the_World_in_Six_Ways", "Around the World in Six Ways - Grand Tree" ),
            new Tuple<string, string>( "Ali_The_Trader", "Mighty Fall - Coins" ),
            new Tuple<string, string>( "Ali_The_Trader", "Death Plateau - Experience" ),
            new Tuple<string, string>( "Ali_The_Trader", "Cabin Fever - Coins" ),
            new Tuple<string, string>( "Ali_The_Trader", "You Are It - Charos' Necklace" ),
            new Tuple<string, string>( "Ali_The_Trader", "Tai Bwo Wannai Trio - Experience" ),
            new Tuple<string, string>( "Ali_The_Trader", "The Lost Tribe - Mining Helmet" ),
            new Tuple<string, string>( "Bloodstained_Treasure", "Bloodstained Treasure" ),
            new Tuple<string, string>( "Cower_Behind_the_Chosen_Commander", "Cower Behind the Chosen Commander" ),
            new Tuple<string, string>( "Daero_Take_This_Experience%3F", "Daero Take This Experience?" ),
            new Tuple<string, string>( "Do_No_Elite", "Do No Elite" ),
            new Tuple<string, string>( "Claiming_the_Knight%27s_Experience", "Claiming the Knight's Experience" ),
            new Tuple<string, string>( "Ali_The_Trader", "Rocking Out - Coins" ),
            new Tuple<string, string>( "Epi_Logueque_Experience", "Epi logueque Experience" ),
            new Tuple<string, string>( "One_Man%27s_Junk...Is_Mine", "One Man's Junk... Is Mine" ),
            new Tuple<string, string>( "Experience_the_Fate_of_the_Gods", "Experience the Fate of the Gods" ),
            new Tuple<string, string>( "Gift_from_Sliske", "Gift from Sliske" ),
            new Tuple<string, string>( "Ali_The_Trader", "The Golem - Gems" ),
            new Tuple<string, string>( "Ali_The_Trader", "One Piercing Note - Cithara Experience" ),
            new Tuple<string, string>( "Ali_The_Trader", "World Wakes - Firemaking" ),
            new Tuple<string, string>( "Ali_The_Trader", "World Wakes - Prayer" ),
            new Tuple<string, string>( "Ali_The_Trader", "The Dig Site - Abilities" ),
            new Tuple<string, string>( "Ali_The_Trader", "Observatory Quest - Craft" ),
            new Tuple<string, string>( "Deadlier_Catch", "Deadler Catch" ),
            new Tuple<string, string>( "I_Presume_These_Rewards_Are_Mine,_Death%3F", "I Presume These Rewards Are Mine, Death?" ),
            new Tuple<string, string>( "Icthlarin's Little Chest", "Icthlarin's Little Chest" ),
            new Tuple<string, string>( "Ali_The_Trader", "One Of A Kind - Experience" ),
            new Tuple<string, string>( "Ali_The_Trader", "One Of A Kind 2 - Statue Experience" ),
            new Tuple<string, string>( "Challenge_Maria", "Challenge Maria - Challenges" ),
            new Tuple<string, string>( "Challenge_Maria", "Challenge Maria - Lamps" ),
            new Tuple<string, string>( "Circus_of_Fire", "Circus of Fire" ),

                
                //Levels
            new Tuple<string, string>( "Gunning_for_Jewellery", "Gunning for Jewellery - Ruby" ),
            new Tuple<string, string>( "Gunning_for_Jewellery", "Gunning for Jewellery - Dragonstone" ),
            new Tuple<string, string>( "Gunning_for_Jewellery", "Gunning for Jewellery - Onyx" ),
            new Tuple<string, string>( "Ali_The_Trader", "50 Farming" ),
            new Tuple<string, string>( "Ali_The_Trader", "50 Attack" ),
            new Tuple<string, string>( "Ali_The_Trader", "50 Prayer" ),
            new Tuple<string, string>( "Ali_The_Trader", "46 Farming" ),
            new Tuple<string, string>( "Ali_The_Trader", "80 Defence" ),
            new Tuple<string, string>( "Ali_The_Trader", "50 Prayer" ),
            new Tuple<string, string>( "Ali_The_Trader", "60 Thieving" ),
            new Tuple<string, string>( "Ali_The_Trader", "50 Smithing" ),
            new Tuple<string, string>( "Ali_The_Trader", "50" ),
            new Tuple<string, string>( "Ali_The_Trader", "100" ),
            new Tuple<string, string>( "Ali_The_Trader", "150" ),
            new Tuple<string, string>( "Ali_The_Trader", "200" ),
            new Tuple<string, string>( "Ali_The_Trader", "250" ),
            new Tuple<string, string>( "Ali_The_Trader", "300" ),
            new Tuple<string, string>( "Ali_The_Trader", "350" ),
            new Tuple<string, string>( "Ali_The_Trader", "400" ),
            new Tuple<string, string>( "Caving_Into_the_Gains", "Caving Into the Gains - Woodcutting" ),
            new Tuple<string, string>( "Caving_Into_the_Gains", "Caving Into the Gains - Agility" ),
            new Tuple<string, string>( "Caving_Into_the_Gains", "Caving Into the Gains - Crafting" ),
            new Tuple<string, string>( "Caving_Into_the_Gains", "Caving Into the Gains - Coins" ),
            new Tuple<string, string>( "Chivalry_is_Dead", "Chivalry is Dead - Runes" ),
            new Tuple<string, string>( "Chivalry_is_Dead", "Chivalry is Dead - Ancient Combat Lamp" ),
            new Tuple<string, string>( "Chivalry_is_Dead", "Chivalry is Dead - Gilded Cabbage" ),
            new Tuple<string, string>( "Chivalry_is_Dead", "Chivalry is Dead - Ancient Prayer Lamp" ),
            new Tuple<string, string>( "Chivalry_Is_Fed", "Chivalry is Fed" ),
            new Tuple<string, string>( "Chivalry_Is_Threads", "Chivalry is Threads" ),
            new Tuple<string, string>( "Brothers_Gower", "Brothers Gower - Ian" ),
            new Tuple<string, string>( "Brothers_Gower", "Brothers Gower - Paul" ),
            new Tuple<string, string>( "Brothers_Gower", "Brothers Gower - Andrew" ),
            new Tuple<string, string>( "Tasty_Bobbles", "Tasty Bobbles" ),


                //Text
            new Tuple<string, string>( "Diaries_of_the_Clans", "Diaries of the Clans" ),
            new Tuple<string, string>( "Diary_of_Oreb", "Diary of Oreb" ),
            new Tuple<string, string>( "Diary_of_the_Gods", "Diary of the Gods" ),
            new Tuple<string, string>( "Do_a_Minion,_Take_Notes", "Do a Minion, Take Notes" ),
            new Tuple<string, string>( "Don%27t_Fear_the_Ripper", "Don't Fear the Ripper" ),
            new Tuple<string, string>( "Dragonkin_Logs", "Dragonkin Logs" ),
            new Tuple<string, string>( "Forcae%27s_Mettle", "Forcae's Mettle" ),
            new Tuple<string, string>( "Ali_The_Trader", "Kaigi" ),
            new Tuple<string, string>( "Ali_The_Trader", "Ughtanatos" ),
            new Tuple<string, string>( "Ali_The_Trader", "Horror" ),
            new Tuple<string, string>( "Ali_The_Trader", "Qbd Journals" ),
            new Tuple<string, string>( "Ali_The_Trader", "Tarddian" ),
            new Tuple<string, string>( "Grondabans%27_legacy", "Grondabans' legacy" ),
            new Tuple<string, string>( "Ali_The_Trader", "Last Riders Book" ),
            new Tuple<string, string>( "Explore_for_Nestor", "Explore for Nestor" ),
            new Tuple<string, string>( "Nex", "The Praesul" ),
            new Tuple<string, string>( "Nex", "The Promised Gift" ),
            new Tuple<string, string>( "Behemoth_Notes_(achievement)", "Behemoth Notes" ),
            new Tuple<string, string>( "History_of_Bilrach", "History of Bilrach" ),
            new Tuple<string, string>( "Dragon_Ink", "Dragon Ink" ),


                //Various
            new Tuple<string, string>( "Angs_off_my_Ring", "Angs off my Ring" ),
            new Tuple<string, string>( "Annihilator", "Annihilator" ),
            new Tuple<string, string>( "Arise_from_the_Ash", "Arise from the Ash" ),
            new Tuple<string, string>( "Enough_of_the_Crazy_Walking", "Enough of the Crazy Walking" ),
            new Tuple<string, string>( "Got_a_Vyre_Reputation", "Got a Vyre Reputation" ),
            new Tuple<string, string>( "Complete_Trekky", "Complete Trekky" ),
            new Tuple<string, string>( "I%27m_Forever_Washing_Shadows", "I'm Forever Washing Shadows" ),
            new Tuple<string, string>( "Ali_The_Trader", "Rush of Blood" ),
            new Tuple<string, string>( "Ali_The_Trader", "30 Chompy Birds" ),
            new Tuple<string, string>( "Ali_The_Trader", "Tooth Creature Pet" ),
            new Tuple<string, string>( "Ali_The_Trader", "History of the Order" ),
            new Tuple<string, string>( "Otto_the_Ancient", "Otto the Ancient" ),
            new Tuple<string, string>( "Ali_The_Trader", "Dimension of Disaster Rewards" ),
            new Tuple<string, string>( "Ali_The_Trader", "Enhanced Fire Cape" ),
            new Tuple<string, string>( "Ali_The_Trader", "Master White Knight" ),
            new Tuple<string, string>( "Ali_The_Trader", "Demon Statuettes" ),
            new Tuple<string, string>( "Goebie_Relics", "Goebie Relics" ),
            new Tuple<string, string>( "Hau_Comes_to_Templeton", "Haul Comes to Templeton" ),
            new Tuple<string, string>( "Herbi%27s_Flax", "Herbi's Flax" ),
            new Tuple<string, string>( "I_Dig_This_Transportation", "I Dig This Transportation" ),
            new Tuple<string, string>( "I_know,_I_was_there...", "I know, I was there..." ),
            new Tuple<string, string>( "Ice_Ice_Chimpy", "Ice Ice Chimpy" ),
            new Tuple<string, string>( "Ali_The_Trader", "Full Kudos obtained" ),
            new Tuple<string, string>( "Ali_The_Trader", "Epic of Bukalla seen" ),
            new Tuple<string, string>( "Ali_The_Trader", "Dorgesh-kaan Food Trading" ),
            new Tuple<string, string>( "Ali_The_Trader", "Razmire and Ulsquire cured" ),
            new Tuple<string, string>( "Ali_The_Trader", "Ourania Teleport unlocked" ),
            new Tuple<string, string>( "Ali_The_Trader", "Wilderness Rogue Trader" ),
            new Tuple<string, string>( "Ali_The_Trader", "Seren Memoriam Crystals" ),
            new Tuple<string, string>( "Ali_The_Trader", "Prifddinas Memoriam Crystals" ),
            new Tuple<string, string>( "Ali_The_Trader", "Zarosian Memoriam Crystals" ),
            new Tuple<string, string>( "Ali_The_Trader", "Helmet of Trials" ),
            new Tuple<string, string>( "As_Taxed_as_a_Yak", "As Taxed as a Yak" ),
            new Tuple<string, string>( "Bandos%27s_Memories_(achievement)", "Bandos's Memories" ),
            new Tuple<string, string>( "Bane_Tuner", "Bane Tuner" ),
            new Tuple<string, string>( "Brutal_Stuffsies", "Brutal Stuffsies" ),
            new Tuple<string, string>( "Cecilia,_I%27m_Begging_You,_Please...", "Cecilia, I'm Begging you, Please" ),
            new Tuple<string, string>( "Challenging_Chat", "Challenging Chat" ),
            new Tuple<string, string>( "Chilling_with_Arrav", "Chilling with Arrav" ),
            new Tuple<string, string>( "Clue%27s_in_the_Monkey_Drool", "Clue's in the Monkey Drool" ),
            new Tuple<string, string>( "Complete_History_of_Droalak", "Complete History of Droalak" ),
            new Tuple<string, string>( "Daemonology_of_Celerity", "Daemonology of Celerity" ),
            new Tuple<string, string>( "Death_to_the_Mahjarrat", "Death to the Mahjarrat" ),
            new Tuple<string, string>( "For_the_Love_of_Mabel", "For the Love of Mabel" ),
            new Tuple<string, string>( "Ali_The_Trader", "Ivandis Flail 500" ),
            new Tuple<string, string>( "Bridge_over_Fremmy_Waters", "Bridge over Fremmy Waters" ),
            new Tuple<string, string>( "Ali_The_Trader", "Potion Recipes" ),
            new Tuple<string, string>( "Ali_The_Trader", "Vicendithas' Scribblings" ),
            new Tuple<string, string>( "All_Rise", "All Rise - 4 Court Cases" ),
            new Tuple<string, string>( "All_Rise", "All Rise - 8 Court Cases" ),
            new Tuple<string, string>( "All_Rise", "All Rise - 12 Court Cases" ),
            new Tuple<string, string>( "All_Rise", "All Rise - 16 Court Cases" ),
            new Tuple<string, string>( "Dishonourable_Gains", "Dishonourable Gains - 50" ),
            new Tuple<string, string>( "Dishonourable_Gains", "Dishonourable Gains - 70" ),
            new Tuple<string, string>( "Dishonourable_Gains", "Dishonourable Gains - 90" ),
            new Tuple<string, string>( "Dishonourable_Loot", "Dishonourable Loot" ),
        };

		public void LoadCheckBoxes()
		{
			string linkPrefix = "https://runescape.wiki/w/";

			AllCheckboxes = new ObservableCollection<CheckBoxModel>	{				
				new CheckBoxModel(CheckBoxType.SelectAll, CheckBoxType.Mqc)
			};	

			checkBoxTupleInfo.ForEach(tuple => {
				AllCheckboxes.Add(new CheckBoxModel(linkPrefix + tuple.Item1, tuple.Item2, CheckBoxType.Mqc));
			});
		}
	}
}
