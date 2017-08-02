<?php

/* form/fields.html.twig */
class __TwigTemplate_2feadd581b5ef307c27eb3c05837a16a617f47b689f0c76d845614dc31e3cf40 extends Twig_Template
{
    public function __construct(Twig_Environment $env)
    {
        parent::__construct($env);

        $this->parent = false;

        $this->blocks = array(
            'date_time_picker_widget' => array($this, 'block_date_time_picker_widget'),
        );
    }

    protected function doDisplay(array $context, array $blocks = array())
    {
        $__internal_734ffd00529be05494a6f63d03618da26ba4e4ed47c1d2dca9151b40fb1c7396 = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_734ffd00529be05494a6f63d03618da26ba4e4ed47c1d2dca9151b40fb1c7396->enter($__internal_734ffd00529be05494a6f63d03618da26ba4e4ed47c1d2dca9151b40fb1c7396_prof = new Twig_Profiler_Profile($this->getTemplateName(), "template", "form/fields.html.twig"));

        // line 9
        echo "
";
        // line 10
        $this->displayBlock('date_time_picker_widget', $context, $blocks);
        
        $__internal_734ffd00529be05494a6f63d03618da26ba4e4ed47c1d2dca9151b40fb1c7396->leave($__internal_734ffd00529be05494a6f63d03618da26ba4e4ed47c1d2dca9151b40fb1c7396_prof);

    }

    public function block_date_time_picker_widget($context, array $blocks = array())
    {
        $__internal_3e62ce3876178da3eac50d9e55a7cded3c1f9e3ba2f756ee39f0e7c03f0ef05b = $this->env->getExtension("Symfony\\Bridge\\Twig\\Extension\\ProfilerExtension");
        $__internal_3e62ce3876178da3eac50d9e55a7cded3c1f9e3ba2f756ee39f0e7c03f0ef05b->enter($__internal_3e62ce3876178da3eac50d9e55a7cded3c1f9e3ba2f756ee39f0e7c03f0ef05b_prof = new Twig_Profiler_Profile($this->getTemplateName(), "block", "date_time_picker_widget"));

        // line 11
        echo "    ";
        ob_start();
        // line 12
        echo "        <div class=\"input-group date\" data-toggle=\"datetimepicker\">
            ";
        // line 13
        $this->displayBlock("datetime_widget", $context, $blocks);
        echo "
            ";
        // line 15
        echo "                ";
        // line 16
        echo "            ";
        // line 17
        echo "        </div>
    ";
        echo trim(preg_replace('/>\s+</', '><', ob_get_clean()));
        
        $__internal_3e62ce3876178da3eac50d9e55a7cded3c1f9e3ba2f756ee39f0e7c03f0ef05b->leave($__internal_3e62ce3876178da3eac50d9e55a7cded3c1f9e3ba2f756ee39f0e7c03f0ef05b_prof);

    }

    public function getTemplateName()
    {
        return "form/fields.html.twig";
    }

    public function getDebugInfo()
    {
        return array (  52 => 17,  50 => 16,  48 => 15,  44 => 13,  41 => 12,  38 => 11,  26 => 10,  23 => 9,);
    }

    public function getSource()
    {
        return "{#
   Each field type is rendered by a template fragment, which is determined
   by the name of your form type class (DateTimePickerType -> date_time_picker)
   and the suffix \"_widget\". This can be controlled by overriding getBlockPrefix()
   in DateTimePickerType.

   See http://symfony.com/doc/current/cookbook/form/create_custom_field_type.html#creating-a-template-for-the-field
#}

{% block date_time_picker_widget %}
    {% spaceless %}
        <div class=\"input-group date\" data-toggle=\"datetimepicker\">
            {{ block('datetime_widget') }}
            {#<span class=\"input-group-addon\">#}
                {#<span class=\"fa fa-calendar\" aria-hidden=\"true\"></span>#}
            {#</span>#}
        </div>
    {% endspaceless %}
{% endblock %}
";
    }
}
