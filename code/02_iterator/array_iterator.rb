class ArrayIterator
  def initialize(array)
    @array = array
    @current = 0
  end

  def first()
    @current = 0
  end

  def next()
    @current += 1
  end

  def is_done()
    return @current >= @array.size()
  end

  def current_item
    return @array.get(@current)
  end
end
