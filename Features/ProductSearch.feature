Feature: ProductSearch

In order to buy items on Amazon,
I need to search for the product


Scenario: ProductSearch
	Given I navigate to amazon website "https://www.amazon.com/"
	And I click on change language
	And I select English
	And I click on currency settings
	And I select British Pounds
	And I click on save change
	And I enter in the Search field
	And I click on search
	And I select McAfee as brand
	And I enter minimum price range
	And I enter maximum Price range
	And I click on Go
	When I select Window's oprating system Product
	Then Window's compatibility product should be displayed
