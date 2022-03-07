# FunBookAndVideoOrderProcessor

FunBooksAndVideos is an e-commerce shop where customers can view books and watch online videos. Users can have memberships for the book
club, the video club or for both clubs (premium).
 

# Description 

- Generate Purchase order by applying relevant business rule. 
- Purchase order contains ID, Customer Information , Total Price and list of items. 
- Items in purchase order can be Membership or physical or non-physical item.
- If membership is present in purchase order then activate membership of customer immediately. (Type of membership can be Book, video or premium)
- Other then membership other item can be Physical or Non-physical
- If item falls under physical category then create Shipping slip 

#  Required Software

.net 5

# How to Install 

- Download code using : "https://github.com/Priyal1989/FunBookAndVideoOrderProcessor.git"
- Extract the Zip file and open project in Visual studio using "FunBooksAndVideos_Processor.sln" file

# Implementation

- IOrderProcess.cs (Class :OrderProcess.cs) is the main file which processing on the order. 
- IRuleGenerator.cs (Class :RuleGenerator.cs) is the file which decide what will be the applicable rule and in what sequence it shold be executed. 
- IRuleExecutore.cs (Class :RuleExecutore.cs) is responsible for actual rule execution based on RuleGenerator's applicable rule and sequnce 
- IShipmentSlipCreator.cs (Class :ShipmentSlipCreator.cs) and IMembershipActivate.cs (Class :BookServiceActivator.cs,MembershipActivate.cs,PremiumServiceActivator.cs & VideoServiceActivator.cs) contains logic for rules.
- IPurchaseOrderCreator.cs (Class:PurchaseOrderCreator.cs) used to create class.

# Requirement

- Implement an Object Oriented model of the system
- Design a flexible purchase order processor
- Implement the above business rules

# Notes

- There is no UI or DataLayer/Repository Implemented for this.
- This application contains only business layer and model. 
- Code contains flexible purchase order processor
- Whenever any business rule will be added you just need to change RuleGenerator and RuleExceutor only. 
- We assume Book as a physical Item and video as non physical item. 
