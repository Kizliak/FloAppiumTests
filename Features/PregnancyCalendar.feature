Feature: PregnancyCalendar
	As a user
	I would like to see calendar of pregnancy
	In order to get info about current week

Scenario: Start pregnancy mode while don't remember pregnancy week
	Given Welcome menu is open
	When I choose I am pregnant
	When I select Not remember pregnancy weeks
	When I select first day of my last period method
	When I select the oldest date in calendar
	When I Choose 2000 year of birthday
	When I click Next button on promo page
	When I close reviews popup
	Then I get to main pregnancy page