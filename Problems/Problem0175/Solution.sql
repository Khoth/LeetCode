SELECT p.firstName, p.lastName, a.city, a.state
FROM Person p (NOLOCK)
LEFT JOIN Address a (NOLOCK) ON p.personId = a.personId