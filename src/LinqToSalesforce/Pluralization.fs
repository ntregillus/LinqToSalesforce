namespace LinqToSalesforce

module Pluralization =

  // https://en.wikipedia.org/wiki/English_plurals

  let (|EndsWith|_|) (e:string) (s:string) =
    if s.EndsWith e
    then Some (s.Substring(0, s.Length - e.Length))
    else None

  let irregulars =
    [ "bison"; "buffalo"; "deer"; "duck"; "fish"; "pike"; "salmon"; "sheep"; "squid"
      "swine"; "trout" ]
  let exceptions =
    dict
      [ "boy", "boys" ]

  let pluralize(text:string) =
    match text with
    | _ when irregulars |> List.contains (text.ToLowerInvariant()) -> text
    | _ when exceptions.ContainsKey(text.ToLowerInvariant()) -> exceptions.Item(text.ToLowerInvariant())
    | EndsWith "ss" t -> t + "sses"
    | EndsWith "se" t -> t + "ses"
    | EndsWith "sh" t -> t + "shes"
    | EndsWith "ch" t -> t + "ches"
    | EndsWith "o" t -> t + "oes"
    | EndsWith "y" t -> t + "ies"
    | EndsWith "f" t -> t + "ves"
    | EndsWith "fe" t -> t + "ves"
    | EndsWith "ld" t -> t + "ldren"
    | EndsWith "x" t -> t + "xen"
    | EndsWith "man" t -> t + "men"
    | EndsWith "oot" t -> t + "eet"
    | EndsWith "oose" t -> t + "eese"
    | EndsWith "ix" t -> t + "ise"
    | EndsWith "ies" t -> t + "ies"
    | EndsWith "um" t -> t + "a"
    | _ -> text + "s"

   //pluralize "kiss"
   //pluralize "shoe"
   //pluralize "life"
   //pluralize "account"
   //pluralize "boy"Ò
   //pluralize "foot"
   //pluralize "death"


