#GuardianApi

A wrapper for the Guardian News Api. http://open-platform.theguardian.com/documentation/

The Guardian provides 5 different APIs:

* Content
* Tags
* Sections
* Editions
* Single item

Each API returns a dataset which is customizable through query parameters.

This library provides easy access to each of these APIs and deserializes the responses into POCO classes for ease of use. There are a number of request classes available which help make full use of the robust Guardian APIs.

An example of an API call:


####Content####

documentation http://open-platform.theguardian.com/documentation/search

endpoint https://content.guardianapis.com/search

example query https://content.guardianapis.com/search?q=12%20years%20a%20slave&format=json&tag=film/film,tone/reviews&from-date=2010-01-01&show-tags=contributor&show-fields=starRating,headline,thumbnail,short-url&show-refinements=all&order-by=relevance

####Tags####

documentation http://open-platform.theguardian.com/documentation/tag

endpoint http://content.guardianapis.com/tags

example query http://content.guardianapis.com/tags?q=apple&section=technology&show-references=all

####Sections####

documentation http://open-platform.theguardian.com/documentation/section

endpoint https://content.guardianapis.com/sections

example query https://content.guardianapis.com/sections?q=business&api-key=test

####Editions####

documentation http://open-platform.theguardian.com/documentation/edition

endpoint https://content.guardianapis.com/editions

example query https://content.guardianapis.com/editions?q=uk&api-key=test

####Single Item####

documentation http://open-platform.theguardian.com/documentation/item

endpoint https://content.guardianapis.com/

example query https://content.guardianapis.com/business/2014/feb/18/uk-inflation-falls-below-bank-england-target