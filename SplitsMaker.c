#include <stdio.h>
#include <stdlib.h>
#include <conio.h>

int game[9] = {0, 0, 0, 0, 0, 0, 0, 0, 0};
char *data;

void addcategory(char *catname)
{
	FILE * fPtr;
	fPtr = fopen("splits.lss", "a");
	data = "<?xml version=\"1.0\" encoding=\"UTF-8\"?>\n<Run version=\"1.7.0\">\n<GameIcon />\n<GameName>Multi-Prince of Persia-Runs</GameName>\n<CategoryName>";
	fputs(data, fPtr);
	fputs(catname, fPtr);
	data = "</CategoryName>\n<Metadata>\n<Run id=\"\" />\n<Platform usesEmulator=\"False\">\n</Platform>\n<Region>\n</Region>\n<Variables />\n</Metadata>\n<Offset>00:00:00</Offset>\n<AttemptCount>0</AttemptCount>\n<AttemptHistory />\n<Segments>\n";
	fputs(data, fPtr);
	fclose(fPtr);
}

void gamecheck(int g)
{
	for(int j=0; j<8; j++)
	{
		if(game[j] == g)
			printf(" (Selected as game %d)",j+1);
	}
}

void addsplit(char *splitname)
{
	FILE * fPtr;
	fPtr = fopen("splits.lss", "a");
	data = "<Segment>\n<Name>";
	fputs(data, fPtr);
	fputs(splitname, fPtr);
	data = "</Name>\n<Icon />\n<SplitTimes>\n<SplitTime name=\"Personal Best\" />\n</SplitTimes>\n<BestSegmentTime />\n<SegmentHistory />\n</Segment>\n";
	fputs(data, fPtr);
	fclose(fPtr);
}

void setupsplit()
{
	FILE * fPtr;
	fPtr = fopen("splits.lss", "a");
	data = "<Segment>\n<Name>Setup</Name>\n<Icon />\n<SplitTimes>\n<SplitTime name=\"Personal Best\" />\n</SplitTimes>\n<BestSegmentTime />\n<SegmentHistory />\n</Segment>\n";
	fputs(data, fPtr);
	fclose(fPtr);
}

void printgame(int g)
{
	switch(g)
	{
		case 1: printf("Prince of Persia (1989)"); break;
		case 2: printf("Prince of Persia 2: Shadow and the Flame"); break;
		case 3: printf("Prince of Persia 3D"); break;
		case 4: printf("Prince of Persia: Sands of Time"); break;
		case 5: printf("Prince of Persia: Warrior Within"); break;
		case 6: printf("Prince of Persia: The Two Thrones"); break;
		case 7: printf("Prince of Persia (2008)"); break;
		case 8: printf("Prince of Persia: The Forgotten Sands"); break;
	}
}

void finishfile()
{
	FILE * fPtr;
	fPtr = fopen("splits.lss", "a");
	data = "</Segments>\n<AutoSplitterSettings />\n</Run>";
	fputs(data, fPtr);
	fclose(fPtr);
}

int main()
{
	int choice;
	fclose(fopen("splits.lss", "w"));

	do{
		system("cls");
		printf("Select Category:");
		printf("\n1. Anthology");
		printf("\n2. Sands Trilogy (Any%, Standard)");
		printf("\n3. Sands Trilogy (Any%, Zipless)");
		printf("\n4. Sands Trilogy (Any%, No Major Glitches)");
		printf("\n5. Sands Trilogy (Completionist, Standard)");
		printf("\n6. Sands Trilogy (Completionist, Zipless)");
		printf("\n7. Sands Trilogy (Completionist, No Major Glitches)");
		printf("\n8. Exit Program");
		printf("\n\nInput: ");
		scanf("%d",&choice);
		switch(choice)
		{
			case 1: addcategory("Anthology");
				for(int i=0; i<8; i++)
				{
					system("cls");
					retry1:
					printf("Selected Category: Anthology\n");
					printf("Select 8 games one by one in the order you wish to play.\n");
					printf("\n1. Prince of Persia (1989)");
					gamecheck(1);
					printf("\n2. Prince of Persia 2: Shadow and the Flame");
					gamecheck(2);
					printf("\n3. Prince of Persia 3D");
					gamecheck(3);
					printf("\n4. Prince of Persia: Sands of Time");
					gamecheck(4);
					printf("\n5. Prince of Persia: Warrior Within");
					gamecheck(5);
					printf("\n6. Prince of Persia: The Two Thrones");
					gamecheck(6);
					printf("\n7. Prince of Persia (2008)");
					gamecheck(7);
					printf("\n8. Prince of Persia: The Forgotten Sands");
					gamecheck(8);
					printf("\n\nSelect game %d: ",i+i);
					scanf("%d",&game[i]);
					switch(game[i])
					{
						case 1:	addsplit("-Level 1");
							addsplit("-Level 2");
							addsplit("-Level 3");
							addsplit("-Level 4");
							addsplit("-Level 5");
							addsplit("-Level 6");
							addsplit("-Level 7");
							addsplit("-Level 8");
							addsplit("-Level 9");
							addsplit("-Level 10");
							addsplit("-Level 11");
							addsplit("-Level 12");
							addsplit("-Level 13");
							addsplit("{Prince of Persia (1989)} Level 14");
						break;
						case 2:	addsplit("-Level 1");
							addsplit("-Level 2");
							addsplit("-Level 3");
							addsplit("-Level 4");
							addsplit("-Level 5");
							addsplit("-Level 6");
							addsplit("-Level 7");
							addsplit("-Level 8");
							addsplit("-Level 9");
							addsplit("-Level 10");
							addsplit("-Level 11");
							addsplit("-Level 12");
							addsplit("-Level 13");
							addsplit("{Shadow and the Flame} Level 14");
						break;
						case 3:	addsplit("-Dungeon");
							addsplit("-Ivory Tower");
							addsplit("-Cistern");
							addsplit("-Palace 1");
							addsplit("-Palace 2");
							addsplit("-Palace 3");
							addsplit("-Rooftops");
							addsplit("-Streets and Docks");
							addsplit("-Lower Dirigible 1");
							addsplit("-Lower Dirigible 2");
							addsplit("-Upper Dirigible");
							addsplit("-Dirigible Finale");
							addsplit("-Floating Ruins");
							addsplit("-Cliffs");
							addsplit("-Sun Temple");
							addsplit("-Moon Temple");
							addsplit("{Prince of Persia 3D} Finale");
						break;
						case 4:	addsplit("-The Treasure Vaults");
							addsplit("-The Sands of Time");
							addsplit("-The Sultan's Chamber (Death)");
							addsplit("-Death of the Sand King");
							addsplit("-The Baths (Death)");
							addsplit("-The Messhall (Death)");
							addsplit("-The Caves");
							addsplit("-Exit Underground Reservoir");
							addsplit("-The Observatory (Death)");
							addsplit("-The Torture Chamber (Death)");
							addsplit("-The Dream");
							addsplit("-Honor and Glory");
							addsplit("-The Grand Rewind");
							addsplit("{The Sands of Time} The End");
						break;
						case 5:	addsplit("-The Boat");
							addsplit("-The Raven Man");
							addsplit("-The Time Portal");
							addsplit("-Mask of the Wraith (59)");
							addsplit("-The Scorpion Sword");
							addsplit("-The Light Sword");
							addsplit("-Back to the Future");
							addsplit("{Warrior Within} The End");
						break;
						case 6:	addsplit("-The Ramparts");
							addsplit("-The Harbour District");
							addsplit("-The Palace");
							addsplit("-Exit Sewers");
							addsplit("-Exit Lower City");
							addsplit("-The Lower City Rooftops");
							addsplit("-Exit Temple Rooftops");
							addsplit("-Exit Marketplace");
							addsplit("-Exit Plaza");
							addsplit("-Exit City Gardens");
							addsplit("-Exit Royal Workshop");
							addsplit("-The King's Road");
							addsplit("-Exit Structure's Mind");
							addsplit("-Exit Labyrith");
							addsplit("-The Towers");
							addsplit("-The Terrace");
							addsplit("{The Two Thrones} The End");
						break;
						case 7:	addsplit("-First Fight Skip");
							addsplit("-Barrier Skip");
							addsplit("-King's Gate");
							addsplit("-Sun Temple");
							addsplit("-Marshalling Grounds");
							addsplit("-Windmills");
							addsplit("-Martyrs' Tower");
							addsplit("-MT -&gt; MG");
							addsplit("-Machinery Ground");
							addsplit("-Heaven's Stair");
							addsplit("-Spire of Dreams");
							addsplit("-Reservoir");
							addsplit("-Construction Yard");
							addsplit("-Cauldron");
							addsplit("-Cavern");
							addsplit("-City Gate");
							addsplit("-Tower of Ormazd");
							addsplit("-Queen's Tower");
							addsplit("-The Temple (Arrive)");
							addsplit("-Double Jump");
							addsplit("-Wings of Ormazd");
							addsplit("-The Warrior");
							addsplit("-Heal Coronation Hall");
							addsplit("-Coronation Hall");
							addsplit("-Heal Heaven's Stair");
							addsplit("-The Alchemist");
							addsplit("-The Hunter");
							addsplit("-Hand of Ormazd");
							addsplit("-The Concubine");
							addsplit("-The King");
							addsplit("-The God");
							addsplit("{Prince of Persia (2008)} Resurrection");
						break;
						case 8:	addsplit("-Malik");
							addsplit("-The Power of Time");
							addsplit("-The Works");
							addsplit("-The Courtyard");
							addsplit("-The Power of Water");
							addsplit("-The Sewers");
							addsplit("-Ratash");
							addsplit("-The Observatory");
							addsplit("-The Power of Light");
							addsplit("-The Gardens");
							addsplit("-The Possession");
							addsplit("-The Power of Knowledge");
							addsplit("-The Reservoir");
							addsplit("-The Power of Razia");
							addsplit("-The Climb");
							addsplit("-The Storm");
							addsplit("{The Forgotten Sands} Grand Finale");
						break;
						default:
							printf("\n\n ERR_Invalid Input, Enter a valid input (a value between 1-8).");
							getch();
							goto retry1;
						break;
					}
					if(i!=7)
					setupsplit();
				}
				system("cls");
				printf("Selected Category: Anthology");
				printf("\n\n 8 games were selected successfully and added to the split file.\n");
				printf("Here is the order:\n");
				for(int i=0; i<8; i++)
				{
					printf("\n%d. ",i+1);
					printgame(game[i]);
				}
				getch();
				choice = 8;
			break;
			case 2:	addcategory("Sands Trilogy (Any%, Standard)");
				for(int i=0; i<3; i++)
				{
					system("cls");
					retry2:
					printf("Selected Category: Sands Trilogy (Any%, Standard)\n");
					printf("Select 3 games one by one in the order you wish to play.\n");
					printf("\n1. Prince of Persia: Sands of Time");
					gamecheck(1);
					printf("\n2. Prince of Persia: Warrior Within");
					gamecheck(2);
					printf("\n3. Prince of Persia: The Two Thrones");
					gamecheck(3);
					printf("\n\nSelect game %d: ",i+1);
					scanf("%d",&game[i]);
					switch(game[i])
					{
						case 1:	addsplit("-The Treasure Vaults");
							addsplit("-The Sands of Time");
							addsplit("-The Sultan's Chamber (Death)");
							addsplit("-Death of the Sand King");
							addsplit("-The Baths (Death)");
							addsplit("-The Messhall (Death)");
							addsplit("-The Caves");
							addsplit("-Exit Underground Reservoir");
							addsplit("-The Observatory (Death)");
							addsplit("-The Torture Chamber (Death)");
							addsplit("-The Dream");
							addsplit("-Honor and Glory");
							addsplit("-The Grand Rewind");
							addsplit("{The Sands of Time} The End");
						break;
						case 2:	addsplit("-The Boat");
							addsplit("-The Raven Man");
							addsplit("-The Time Portal");
							addsplit("-Mask of the Wraith (59)");
							addsplit("-The Scorpion Sword");
							addsplit("-The Light Sword");
							addsplit("-Back to the Future");
							addsplit("{Warrior Within} The End");	
						break;
						case 3:	addsplit("-The Ramparts");
							addsplit("-The Harbour District");
							addsplit("-The Palace");
							addsplit("-Exit Sewers");
							addsplit("-Exit Lower City");
							addsplit("-The Lower City Rooftops");
							addsplit("-Exit Temple Rooftops");
							addsplit("-Exit Marketplace");
							addsplit("-Exit Plaza");
							addsplit("-Exit City Gardens");
							addsplit("-Exit Royal Workshop");
							addsplit("-The King's Road");
							addsplit("-Exit Structure's Mind");
							addsplit("-Exit Labyrith");
							addsplit("-The Towers");
							addsplit("-The Terrace");
							addsplit("{The Two Thrones} The End");	
						break;
						default:
							printf("\n\n ERR_Invalid Input, Enter a valid input (a value between 1-3).");
							getch();
							goto retry2;
						break;
					}
					if(i!=2)
					setupsplit();
				}
				system("cls");
				printf("Selected Category: Sands Trilogy (Any%, Standard)");
				printf("\n\n 3 games were selected successfully and added to the split file.\n");
				printf("Here is the order:\n");
				for(int i=0; i<3; i++)
				{
					printf("\n%d. ",i+1);
					printgame(game[i]+3);
				}
				getch();
				choice = 8;
			break;
			case 3:	addcategory("Sands Trilogy (Any%, Zipless)");
				for(int i=0; i<3; i++)
				{
					system("cls");
					retry3:
					printf("Selected Category: Sands Trilogy (Any%, Zipless)\n");
					printf("Select 3 games one by one in the order you wish to play.\n");
					printf("\n1. Prince of Persia: Sands of Time");
					gamecheck(1);
					printf("\n2. Prince of Persia: Warrior Within");
					gamecheck(2);
					printf("\n3. Prince of Persia: The Two Thrones");
					gamecheck(3);
					printf("\n\nSelect game %d: ",i+1);
					scanf("%d",&game[i]);
					switch(game[i])
					{
						case 1:	addsplit("-The Treasure Vaults");
							addsplit("-The Sands of Time");
							addsplit("-First Guest Room");
							addsplit("-The Sultan's Chamber");
							addsplit("-Exit Palace Defense");
							addsplit("-The Sand King");
							addsplit("-Death of the Sand King");
							addsplit("-The Warehouse");
							addsplit("-The Zoo");
							addsplit("-Atop a Bird Cage");
							addsplit("-Cliffs and Waterfall");
							addsplit("-The Baths");
							addsplit("-Sword of the Mighty Warrior");
							addsplit("-Daybreak");
							addsplit("-Drawbridge Tower");
							addsplit("-A Broken Bridge");
							addsplit("-The Caves");
							addsplit("-Waterfall");
							addsplit("-Underground Reservoir");
							addsplit("-Hall of Learning");
							addsplit("-Exit Observatory");
							addsplit("-Exit Hall of Learning Courtyards");
							addsplit("-The Prison");
							addsplit("-The Torture Chamber");
							addsplit("-The Elevator");
							addsplit("-The Dream");
							addsplit("-The Tomb");
							addsplit("-The Tower of Dawn");
							addsplit("-The Setting Sun");
							addsplit("-Honor and Glory");
							addsplit("-The Grand Rewind");
							addsplit("{The Sands of Time} The End");
						break;
						case 2:	addsplit("-The Boat");
							addsplit("-The Raven Man");
							addsplit("-The Time Portal");
							addsplit("-Mask of the Wraith (59)");
							addsplit("-The Scorpion Sword");
							addsplit("-The Light Sword");
							addsplit("-Back to the Future");
							addsplit("{Warrior Within} The End");
						break;
						case 3:	addsplit("-The Ramparts");
							addsplit("-The Harbour District");
							addsplit("-The Palace");
							addsplit("-The Trapped Hallway");
							addsplit("-The Sewers");
							addsplit("-The Fortress");
							addsplit("-The Lower City");
							addsplit("-The Lower City Rooftops");
							addsplit("-The Balconies");
							addsplit("-The Dark Alley");
							addsplit("-The Temple Rooftops");
							addsplit("-Exit Marketplace");
							addsplit("-The Market District");
							addsplit("-Exit Plaza");
							addsplit("-The Upper City");
							addsplit("-The City Gardens");
							addsplit("-The Promenade");
							addsplit("-The Royal Workshop");
							addsplit("-The King's Road");
							addsplit("-The Palace Entrance");
							addsplit("-The Hanging Gardens");
							addsplit("-The Structure's Mind");
							addsplit("-The Well of Ancestors");
							addsplit("-The Labyrinth");
							addsplit("-The Underground Cave");
							addsplit("-The Lower Tower");
							addsplit("-The Upper Tower");
							addsplit("-The Terrace");
							addsplit("{The Two Thrones} The End");
						break;
						default:
							printf("\n\n ERR_Invalid Input, Enter a valid input (a value between 1-3).");
							getch();
							goto retry3;
						break;
					}
					if(i!=2)
					setupsplit();
				}
				system("cls");
				printf("Selected Category: Sands Trilogy (Any%, Zipless)");
				printf("\n\n 3 games were selected successfully and added to the split file.\n");
				printf("Here is the order:\n");
				for(int i=0; i<3; i++)
				{
					printf("\n%d. ",i+1);
					printgame(game[i]+3);
				}
				getch();
				choice = 8;
			break;
			case 4:	addcategory("Sands Trilogy (Any%, No Major Glitches)");
				for(int i=0; i<3; i++)
				{
					system("cls");
					retry4:
					printf("Selected Category: Sands Trilogy (Any%, No Major Glitches)\n");
					printf("Select 3 games one by one in the order you wish to play.\n");
					printf("\n1. Prince of Persia: Sands of Time");
					gamecheck(1);
					printf("\n2. Prince of Persia: Warrior Within");
					gamecheck(2);
					printf("\n3. Prince of Persia: The Two Thrones");
					gamecheck(3);
					printf("\n\nSelect game %d: ",i+1);
					scanf("%d",&game[i]);
					switch(game[i])
					{
						case 1:	addsplit("-The Treasure Vaults");
							addsplit("-The Sands of Time");
							addsplit("-First Guest Room");
							addsplit("-The Sultan's Chamber");
							addsplit("-Exit Palace Defense");
							addsplit("-The Sand King");
							addsplit("-Death of the Sand King");
							addsplit("-The Warehouse");
							addsplit("-The Zoo");
							addsplit("-Atop a Bird Cage");
							addsplit("-Cliffs and Waterfall");
							addsplit("-The Baths");
							addsplit("-Sword of the Mighty Warrior");
							addsplit("-Daybreak");
							addsplit("-Drawbridge Tower");
							addsplit("-A Broken Bridge");
							addsplit("-The Caves");
							addsplit("-Waterfall");
							addsplit("-Underground Reservoir");
							addsplit("-Hall of Learning");
							addsplit("-Exit Observatory");
							addsplit("-Exit Hall of Learning Courtyards");
							addsplit("-The Prison");
							addsplit("-The Torture Chamber");
							addsplit("-The Elevator");
							addsplit("-The Dream");
							addsplit("-The Tomb");
							addsplit("-The Tower of Dawn");
							addsplit("-The Setting Sun");
							addsplit("-Honor and Glory");
							addsplit("-The Grand Rewind");
							addsplit("{The Sands of Time} The End");
						break;
						case 2:	addsplit("-The Boat");
							addsplit("-The Spider Sword");
							addsplit("-Chasing Shadee");
							addsplit("-A Damsel in Distress");
							addsplit("-The Dahaka");
							addsplit("-The Serpent Sword");
							addsplit("-The Garden Hall");
							addsplit("-The Waterworks Restored");
							addsplit("-The Lion Sword");
							addsplit("-The Mechanical Tower");
							addsplit("-Breath of Fate");
							addsplit("-Activation Room  in Ruin");
							addsplit("-Activation Room Restored");
							addsplit("-The Death of a Sand Wraith");
							addsplit("-Death of the Empress");
							addsplit("-Exit the Tomb");
							addsplit("-The Scorpion Sword");
							addsplit("-The Library");
							addsplit("-The Hourglass Revisited");
							addsplit("-Mask of the Wraith");
							addsplit("-The Sand Griffin");
							addsplit("-Mirrored Fates");
							addsplit("-A Favor Unknown");
							addsplit("-The Library Revisited");
							addsplit("-The Light Sword");
							addsplit("-The Death of a Prince");
							addsplit("{Warrior Within} The End");
						break;
						case 3:	addsplit("-The Ramparts");
							addsplit("-The Harbour District");
							addsplit("-The Palace");
							addsplit("-The Trapped Hallway");
							addsplit("-The Sewers");
							addsplit("-The Fortress");
							addsplit("-The Lower City");
							addsplit("-The Lower City Rooftops");
							addsplit("-The Balconies");
							addsplit("-The Dark Alley");
							addsplit("-The Temple Rooftops");
							addsplit("-The Temple");
							addsplit("-The Marketplace");
							addsplit("-The Market District");
							addsplit("-The Brothel");
							addsplit("-The Plaza");
							addsplit("-The Upper City");
							addsplit("-The City Gardens");
							addsplit("-The Promenade");
							addsplit("-The Royal Workshop");
							addsplit("-The King's Road");
							addsplit("-The Palace Entrance");
							addsplit("-The Hanging Gardens");
							addsplit("-The Structure's Mind");
							addsplit("-The Well of Ancestors");
							addsplit("-The Labyrinth");
							addsplit("-The Underground Cave");
							addsplit("-The Lower Tower");
							addsplit("-The Middle Tower");
							addsplit("-The Upper Tower");
							addsplit("-The Terrace");
							addsplit("{The Two Thrones} The End");
						break;
						default:
							printf("\n\n ERR_Invalid Input, Enter a valid input (a value between 1-3).");
							getch();
							goto retry4;
						break;
					}
					if(i!=2)
					setupsplit();
				}
				system("cls");
				printf("Selected Category: Sands Trilogy (Any%, No Major Glitches)");
				printf("\n\n 3 games were selected successfully and added to the split file.\n");
				printf("Here is the order:\n");
				for(int i=0; i<3; i++)
				{
					printf("\n%d. ",i+1);
					printgame(game[i]+3);
				}
				getch();
				choice = 8;
			break;
			case 5:	addcategory("Sands Trilogy (Completionist, Standard)");
				for(int i=0; i<3; i++)
				{
					system("cls");
					retry5:
					printf("Selected Category: Sands Trilogy (Completionist, Standard)\n");
					printf("Select 3 games one by one in the order you wish to play.\n");
					printf("\n1. Prince of Persia: Sands of Time");
					gamecheck(1);
					printf("\n2. Prince of Persia: Warrior Within");
					gamecheck(2);
					printf("\n3. Prince of Persia: The Two Thrones");
					gamecheck(3);
					printf("\n\nSelect game %d: ",i+1);
					scanf("%d",&game[i]);
					switch(game[i])
					{
						case 1:	addsplit("-The Treasure Vaults");
							addsplit("-The Sands of Time");
							addsplit("-Life Upgrade 1");
							addsplit("-Life Upgrade 2");
							addsplit("-Life Upgrade 3");
							addsplit("-The Baths (Death)");
							addsplit("-Life Upgrade 4");
							addsplit("-The Messhall (Death)");
							addsplit("-Life Upgrade 5");
							addsplit("-The Caves (Death)");
							addsplit("-Life Upgrade 6");
							addsplit("-Life Upgrade 7");
							addsplit("-The Observatory (Death)");
							addsplit("-Life Upgrade 8");
							addsplit("-Life Upgrade 9");
							addsplit("-The Dream");
							addsplit("-Life Upgrade 10");
							addsplit("-Honor and Glory");
							addsplit("-The Grand Rewind");
							addsplit("{The Sands of Time} The End");	
						break;
						case 2:	addsplit("-The Boat");
							addsplit("-The Raven Man");
							addsplit("-Life Upgrade 1");
							addsplit("-Life Upgrade 2");
							addsplit("-Life Upgrade 3");
							addsplit("-Life Upgrade 4");
							addsplit("-Life Upgrade 5");
							addsplit("-Life Upgrade 6");
							addsplit("-Life Upgrade 7");
							addsplit("-Life Upgrade 8");
							addsplit("-Life Upgrade 9");
							addsplit("-The Water Sword");
							addsplit("{Warrior Within} The End");
						break;
						case 3:	addsplit("-The Ramparts");
							addsplit("-The Harbour District");
							addsplit("-The Palace");
							addsplit("-Life Upgrade 1");
							addsplit("-Exit Lower City");
							addsplit("-Life Upgrade 2");
							addsplit("-The Arena");
							addsplit("-Exit Temple Rooftops");
							addsplit("-Life Upgrade 3");
							addsplit("-The Marketplace");
							addsplit("-Exit Plaza");
							addsplit("-Life Upgrade 4");
							addsplit("-Exit Royal Workshop");
							addsplit("-The King's Road");
							addsplit("-Life Upgrade 5");
							addsplit("-Exit Structure's Mind");
							addsplit("-Exit Labyrith");
							addsplit("-Life Upgrade 6");
							addsplit("-The Upper Tower");
							addsplit("-The Terrace");
							addsplit("{The Two Thrones} The End");
						break;
						default:
							printf("\n\n ERR_Invalid Input, Enter a valid input (a value between 1-3).");
							getch();
							goto retry5;
						break;
					}
					if(i!=2)
					setupsplit();
				}
				system("cls");
				printf("Selected Category: Sands Trilogy (Completionist, Standard)");
				printf("\n\n 3 games were selected successfully and added to the split file.\n");
				printf("Here is the order:\n");
				for(int i=0; i<3; i++)
				{
					printf("\n%d. ",i+1);
					printgame(game[i]+3);
				}
				getch();
				choice = 8;
			break;
			case 6:	addcategory("Sands Trilogy (Completionist, Zipless)");
				for(int i=0; i<3; i++)
				{
					system("cls");
					retry6:
					printf("Selected Category: Sands Trilogy (Completionist, Zipless)\n");
					printf("Select 3 games one by one in the order you wish to play.\n");
					printf("\n1. Prince of Persia: Sands of Time");
					gamecheck(1);
					printf("\n2. Prince of Persia: Warrior Within");
					gamecheck(2);
					printf("\n3. Prince of Persia: The Two Thrones");
					gamecheck(3);
					printf("\n\nSelect game %d: ",i+1);
					scanf("%d",&game[i]);
					switch(game[i])
					{
						case 1:	addsplit("-The Treasure Vaults");
							addsplit("-The Sands of Time");
							addsplit("-First Guest Room");
							addsplit("-Life Upgrade 1");
							addsplit("-Exit Palace Defense");
							addsplit("-Life Upgrade 2");
							addsplit("-Death of the Sand King");
							addsplit("-Life Upgrade 3");
							addsplit("-The Zoo");
							addsplit("-Atop a Bird Cage");
							addsplit("-Cliffs and Waterfall");
							addsplit("-The Baths");
							addsplit("-Life Upgrade 4");
							addsplit("-Daybreak");
							addsplit("-Drawbridge Tower");
							addsplit("-A Broken Bridge");
							addsplit("-Life Upgrade 5");
							addsplit("-Waterfall");
							addsplit("-Underground Reservoir");
							addsplit("-Life Upgrade 6");
							addsplit("-Hall of Learning");
							addsplit("-Life Upgrade 7");
							addsplit("-Exit Observatory");
							addsplit("-Exit Hall of Learning Courtyards");
							addsplit("-The Prison");
							addsplit("-Life Upgrade 8");
							addsplit("-Life Upgrade 9");
							addsplit("-The Dream");
							addsplit("-The Tomb");
							addsplit("-Life Upgrade 10");
							addsplit("-The Tower of Dawn");
							addsplit("-The Setting Sun");
							addsplit("-Honor and Glory");
							addsplit("-The Grand Rewind");
							addsplit("{The Sands of Time} The End");
						break;
						case 2:	addsplit("-The Boat");
							addsplit("-The Raven Man");
							addsplit("-Life Upgrade 1");
							addsplit("-Life Upgrade 2");
							addsplit("-Life Upgrade 3");
							addsplit("-Life Upgrade 4");
							addsplit("-Mask of the Wraith (59)");
							addsplit("-Life Upgrade 5");
							addsplit("-Life Upgrade 6");
							addsplit("-The Mechanical Tower");
							addsplit("-Life Upgrade 7");
							addsplit("-Life Upgrade 8");
							addsplit("-Life Upgrade 9");
							addsplit("-The Water Sword");
							addsplit("{Warrior Within} The End");
						break;
						case 3:	addsplit("-The Ramparts");
							addsplit("-The Harbour District");
							addsplit("-The Palace");
							addsplit("-The Trapped Hallway");
							addsplit("-Life Upgrade 1");
							addsplit("-The Fortress");
							addsplit("-The Lower City");
							addsplit("-Life Upgrade 2");
							addsplit("-The Arena");
							addsplit("-The Balconies");
							addsplit("-The Dark Alley");
							addsplit("-The Temple Rooftops");
							addsplit("-Life Upgrade 3");
							addsplit("-The Marketplace");
							addsplit("-The Market District");
							addsplit("-Exit Plaza");
							addsplit("-The Upper City");
							addsplit("-Life Upgrade 4");
							addsplit("-The Promenade");
							addsplit("-The Royal Workshop");
							addsplit("-The King's Road");
							addsplit("-Life Upgrade 5");
							addsplit("-The Hanging Gardens");
							addsplit("-The Structure's Mind");
							addsplit("-The Well of Ancestors");
							addsplit("-The Labyrinth");
							addsplit("-The Underground Cave");
							addsplit("-The Lower Tower");
							addsplit("-Life Upgrade 6");
							addsplit("-The Upper Tower");
							addsplit("-The Terrace");
							addsplit("{The Two Thrones} The End");
						break;
						default:
							printf("\n\n ERR_Invalid Input, Enter a valid input (a value between 1-3).");
							getch();
							goto retry6;
						break;
					}
					if(i!=2)
					setupsplit();
				}
				system("cls");
				printf("Selected Category: Sands Trilogy (Completionist, Zipless)");
				printf("\n\n 3 games were selected successfully and added to the split file.\n");
				printf("Here is the order:\n");
				for(int i=0; i<3; i++)
				{
					printf("\n%d. ",i+1);
					printgame(game[i]+3);
				}
				getch();
				choice = 8;
			break;
			case 7:	addcategory("Sands Trilogy (Completionist, No Major Glitches)");
				for(int i=0; i<3; i++)
				{
					system("cls");
					retry7:
					printf("Selected Category: Sands Trilogy (Completionist, No Major Glitches)\n");
					printf("Select 3 games one by one in the order you wish to play.\n");
					printf("\n1. Prince of Persia: Sands of Time");
					gamecheck(1);
					printf("\n2. Prince of Persia: Warrior Within");
					gamecheck(2);
					printf("\n3. Prince of Persia: The Two Thrones");
					gamecheck(3);
					printf("\n\nSelect game %d: ",i+1);
					scanf("%d",&game[i]);
					switch(game[i])
					{
						case 1:	addsplit("-The Treasure Vaults");
							addsplit("-The Sands of Time");
							addsplit("-First Guest Room");
							addsplit("-Life Upgrade 1");
							addsplit("-Exit Palace Defense");
							addsplit("-Life Upgrade 2");
							addsplit("-Death of the Sand King");
							addsplit("-Life Upgrade 3");
							addsplit("-The Zoo");
							addsplit("-Atop a Bird Cage");
							addsplit("-Cliffs and Waterfall");
							addsplit("-The Baths");
							addsplit("-Life Upgrade 4");
							addsplit("-Daybreak");
							addsplit("-Drawbridge Tower");
							addsplit("-A Broken Bridge");
							addsplit("-Life Upgrade 5");
							addsplit("-Waterfall");
							addsplit("-Underground Reservoir");
							addsplit("-Life Upgrade 6");
							addsplit("-Hall of Learning");
							addsplit("-Life Upgrade 7");
							addsplit("-Exit Observatory");
							addsplit("-Exit Hall of Learning Courtyards");
							addsplit("-The Prison");
							addsplit("-Life Upgrade 8");
							addsplit("-Life Upgrade 9");
							addsplit("-The Dream");
							addsplit("-The Tomb");
							addsplit("-Life Upgrade 10");
							addsplit("-The Tower of Dawn");
							addsplit("-The Setting Sun");
							addsplit("-Honor and Glory");
							addsplit("-The Grand Rewind");
							addsplit("{The Sands of Time} The End");
						break;
						case 2:	addsplit("-The Boat");
							addsplit("-The Spider Sword");
							addsplit("-Life Upgrade 1");
							addsplit("-A Damsel in Distress");
							addsplit("-Life Upgrade 2");
							addsplit("-The Dahaka");
							addsplit("-Life Upgrade 3");
							addsplit("-The Serpent Sword");
							addsplit("-The Waterworks Restored");
							addsplit("-Life Upgrade 4");
							addsplit("-Life Upgrade 5");
							addsplit("-Life Upgrade 6");
							addsplit("-The Mechanical Tower");
							addsplit("-Breath of Fate");
							addsplit("-Activation Room  in Ruin");
							addsplit("-Life Upgrade 7");
							addsplit("-The Death of a Sand Wraith");
							addsplit("-Death of the Empress");
							addsplit("-Exit the Tomb");
							addsplit("-The Scorpion Sword");
							addsplit("-Life Upgrade 8");
							addsplit("-Life Upgrade 9");
							addsplit("-The Water Sword");
							addsplit("-Mask of the Wraith");
							addsplit("-The Sand Griffin");
							addsplit("-Mirrored Fates");
							addsplit("-A Favor Unknown");
							addsplit("-The Library Revisited");
							addsplit("-The Light Sword");
							addsplit("-The Death of a Prince");
							addsplit("{Warrior Within} The End");
						break;
						case 3:	addsplit("-The Ramparts");
							addsplit("-The Harbour District");
							addsplit("-The Palace");
							addsplit("-The Trapped Hallway");
							addsplit("-Life Upgrade 1");
							addsplit("-The Fortress");
							addsplit("-The Lower City");
							addsplit("-Life Upgrade 2");
							addsplit("-The Arena");
							addsplit("-The Balconies");
							addsplit("-The Dark Alley");
							addsplit("-The Temple Rooftops");
							addsplit("-Life Upgrade 3");
							addsplit("-The Marketplace");
							addsplit("-The Market District");
							addsplit("-The Brothel");
							addsplit("-The Plaza");
							addsplit("-The Upper City");
							addsplit("-The City Gardens");
							addsplit("-The Promenade");
							addsplit("-The Royal Workshop");
							addsplit("-The King's Road");
							addsplit("-Life Upgrade 5");
							addsplit("-The Hanging Gardens");
							addsplit("-The Structure's Mind");
							addsplit("-The Well of Ancestors");
							addsplit("-The Labyrinth");
							addsplit("-The Underground Cave");
							addsplit("-The Lower Tower");
							addsplit("-Life Upgrade 6");
							addsplit("-The Upper Tower");
							addsplit("-The Terrace");
							addsplit("{The Two Thrones} The End");
						break;
						default:
							printf("\n\n ERR_Invalid Input, Enter a valid input (a value between 1-3).");
							getch();
							goto retry7;
						break;
					}
					if(i!=2)
					setupsplit();
				}
				system("cls");
				printf("Selected Category: Sands Trilogy (Completionist, No Major Glitches)");
				printf("\n\n 3 games were selected successfully and added to the split file.\n");
				printf("Here is the order:\n");
				for(int i=0; i<3; i++)
				{
					printf("\n%d. ",i+1);
					printgame(game[i]+3);
				}
				getch();
				choice = 8;
			break;
			default:
			break;
		}
	}
	while(choice!=8);
	
	finishfile();
	return 0;
}