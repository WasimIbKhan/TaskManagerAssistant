function scrollContainer(elementId, direction)
{
    var container = document.getElementById(elementId);
    if (container)
    {
        var scrollAmount = direction === 'left' ? -300 : 300;
        container.scrollBy({ left: scrollAmount, behavior: 'smooth' });
    }
}
