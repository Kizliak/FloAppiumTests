Feature: TrackMyCycle
	As a user
	I want to be able to track my cycle

Background:
	Given Welcome menu is open

Scenario Outline: Check if it is possible to run the app in the Track my cycle mode from the Welcome menu
	When I tap on Track my cycle button
	When I tap on I don't remember checkbox
	When I tap on don't remember Next button
	When I swipe from Select to one position up
	When I tap on year born Next button
	When I tap on <Is your cycle regular> answer button
	When I tap on <Do you experience discomfort> answer button
	When I tap on Next button answer question
	When I tap on <Have reproductive disorders> answer button
	When I tap on <Is you want to improve sleep> answer button
	When I tap on Next button answer question
	When I tap on <Are there mental health> answer button
	When I tap on Next button answer question
	When I tap on <What change about sex> answer button
	When I tap on Next button answer question
	When I tap on <What fitness goal> answer button
	When I tap on Next button answer question
	When I tap on <Anything to change about skin> answer button
	When I tap on Next button answer question
	When I tap on No button on Do you take supplements
	When I tap on Welcome mode page Next button
	When I tap on Welcome mode page Next button
	When I tap on Welcome mode page Next button
	When I tap on Choose your plan X button
	Then The message 'Log the first day of your last period for better predictions' appears on the Track my cycle mode main page
	When I tap on Track my cycle menu button
	Then Track cycle button selected

	Examples:
		| Is your cycle regular | Do you experience discomfort | Have reproductive disorders | Is you want to improve sleep | Are there mental health   | What change about sex          | What fitness goal       | Anything to change about skin |
		| My cycle is regular   | Painful menstrual cramps     | Yes                         | No, I sleep well             | Nothing, I'm totally fine | Nothing, I'm totally satisfied | None                    | None, I have perfect skin     |
		| My cycle is irregular | PMS symptoms                 | No                          | Difficulty falling asleep    | Stress                    | I'm not sexually active now    | Lose weight             | Acne and blemishes            |
		| I don't know          | Unusual discharge            | No, but I used to           | Waking up tired              | Mood fluctuations         | Painful sex                    | Gain weight             | Dark spots and pores          |
		| My cycle is regular   | Heavy menstrual flow         | I don't know                | Waking up during the night   | Anxiety                   | Difficulty with orgasm         | Maintain healthy weight | Dryness                       |
		| My cycle is irregular | Mood swings                  | Yes                         | Lack of sleep schedule       | Depressed mood            | Low libido                     | Start exercising        | Fine lines and wrinkles       |
		| I don't know          | Other                        | No                          | Insomnia                     | Low energy                | Communication                  | Learn about nutrition   | Dullness and texture          |
		| My cycle is regular   | No, nothing bothers me       | No, but I used to           | Other                        | Poor self-image           | Poor body image                | Get more energy         | Other                         |
		| My cycle is irregular | Painful menstrual cramps     | I don't know                | No, I sleep well             | Other                     | Other                          | Other                   | None, I have perfect skin     |